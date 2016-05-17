using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Input.Inking;
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls;
using deskx_uwp.protobuf;
using Google.Protobuf;

namespace desk_uwp.protobuf
{
    class InkDataManager
    {
        private readonly InkCanvas sourceCanvas;
        private int _lastIndex;
        bool _isDone = false;
        public InkDataManager(InkCanvas source)
        {
            sourceCanvas = source;
            Initialization = SendInk();
        }
        public Task Initialization { get; private set; }
        public async Task SendInk()
        {
            
            while (!_isDone)
            {
                await Task.Delay(TimeSpan.FromSeconds(0.1));
                InkStrokeContainer strokes = new InkStrokeContainer();
                var readyToGo = false;
                readyToGo = sourceCanvas.InkPresenter.StrokeContainer.GetStrokes().Count > 0;
                readyToGo = sourceCanvas.InkPresenter.StrokeContainer.GetStrokes().Count != (_lastIndex);
                if (!readyToGo) continue;
                Debug.WriteLine("We're comparing last index: " + _lastIndex + " and container count: " +
                                sourceCanvas.InkPresenter.StrokeContainer.GetStrokes().Count);
                //lets loop through the internal inkcanvas and copy the latest strokes into a container
                for (var i = _lastIndex; i < sourceCanvas.InkPresenter.StrokeContainer.GetStrokes().Count; ++i)
                {
                    InkStroke stroke = sourceCanvas.InkPresenter.StrokeContainer.GetStrokes()[i].Clone();
                    strokes.AddStroke(stroke);
                    _lastIndex = i;
                }
                _lastIndex++;
                Debug.WriteLine("Last Index is: " + _lastIndex);
                Debug.WriteLine("Total in Canvas: " + sourceCanvas.InkPresenter.StrokeContainer.GetStrokes().Count);
                Debug.WriteLine("Amount of strokes in this segment: " + strokes.GetStrokes().Count);
                //make a webGen object so we can send our strokes data to the server
                MemoryStream ms = new MemoryStream();
                await strokes.SaveAsync(ms.AsOutputStream());

                WebGen web = new WebGen("http://localhost:8000/desk/session/object/store/", "POST",
                    "application/deskdata");
                SessionObject sessionData = new SessionObject
                {
                    Session = App.CurrentSession,
                    Type = "InkStroke",
                    Data = Convert.ToBase64String(ms.ToArray()),
                    InsertTime = DateTime.UtcNow.ToString(),

                };
                await web.SendRequestData(sessionData);
                MemoryStream mem = await web.GetResponse();
//          get response from the webgen object and then parse it into a readable protobuf object
                SessionResponse sessionResponse = SessionResponse.Parser.ParseFrom(mem.ToArray());
                if (sessionResponse.Error)
                {
                    var dialog = new MessageDialog(sessionResponse.Message);
                    await dialog.ShowAsync();
                }
            }
        }

        public void StopSending()
        {
            _isDone = true;
        }

//        public async Task<InkStrokeContainer> GiveInk()
//        {
//            return new InkStrokeContainer();
////            we're gonna grab all the ink here
//        }
    }
}
