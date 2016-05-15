using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Input.Inking;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Threading.Tasks;
using Windows.Storage.Streams;
using System.Runtime.Serialization;
using deskx_uwp.protobuf;
using System.Net;
using Google.Protobuf;
using Windows.Security.Cryptography;
using System.IO.Compression;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace desk_uwp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class deskView : Page
    {
        public deskView()
        {
            this.InitializeComponent();

            inkCanvas.InkPresenter.InputDeviceTypes =
            Windows.UI.Core.CoreInputDeviceTypes.Mouse |
            Windows.UI.Core.CoreInputDeviceTypes.Pen |
            Windows.UI.Core.CoreInputDeviceTypes.Touch;

            // Set initial ink stroke attributes.
            InkDrawingAttributes drawingAttributes = new InkDrawingAttributes();
            drawingAttributes.Color = Windows.UI.Colors.Black;
            drawingAttributes.IgnorePressure = false;
            drawingAttributes.FitToCurve = true;
            inkCanvas.InkPresenter.UpdateDefaultDrawingAttributes(drawingAttributes);
            inkCanvas.InkPresenter.StrokeContainer.GetStrokes();
            
        }
        public async Task<bool> saveStrokes()
        {
            InkStrokeContainer strokes = new InkStrokeContainer(); 
            if (inkCanvas.InkPresenter.StrokeContainer.GetStrokes().Count > 0)
            {
                for(int i = 0; i < inkCanvas.InkPresenter.StrokeContainer.GetStrokes().Count; i++)
                {
                    InkStroke stroke = inkCanvas.InkPresenter.StrokeContainer.GetStrokes()[i].Clone();
                    strokes.AddStroke(stroke);
                }
                MemoryStream ms = new MemoryStream();
                await strokes.SaveAsync(ms.AsOutputStream());

                WebRequest webRequest = WebRequest.Create("http://localhost:8000/desk/session/object/store/");
                webRequest.Credentials = CredentialCache.DefaultCredentials;
                webRequest.Method = "POST";
                webRequest.ContentType = "application/deskdata";
                var dt = new DateTime(2010, 1, 1, 1, 1, 1, DateTimeKind.Utc);
                string s = dt.ToLocalTime().ToString("yyyy-MM-dd HH:mm:ss \"GMT\"zzz");
                SessionObject sessionData = new SessionObject
                {
                    Session = App.CurrentSession,
                    Type = "InkStroke",
                    Data = Convert.ToBase64String(ms.ToArray()),
                    InsertTime = s,

                };
                MessageExtensions.WriteTo(sessionData, await webRequest.GetRequestStreamAsync());

                WebResponse response = await webRequest.GetResponseAsync();
                Stream responseStream = response.GetResponseStream();
                ms = new MemoryStream();
                responseStream.CopyTo(ms);

                SessionResponse sessionResponse = SessionResponse.Parser.ParseFrom(ms.ToArray());
                return !sessionResponse.Error;

            }
            return true;
        }
        private void OnPenColorChanged(object sender, SelectionChangedEventArgs e)
        {
            if (inkCanvas != null)
            {
                InkDrawingAttributes drawingAttributes =
                    inkCanvas.InkPresenter.CopyDefaultDrawingAttributes();

                string value = ((ComboBoxItem)PenColor.SelectedItem).Content.ToString();

                switch (value)
                {
                    case "Black":
                        drawingAttributes.Color = Windows.UI.Colors.Black;
                        break;
                    case "Red":
                        drawingAttributes.Color = Windows.UI.Colors.Red;
                        break;
                    default:
                        drawingAttributes.Color = Windows.UI.Colors.Black;
                        break;
                };

                inkCanvas.InkPresenter.UpdateDefaultDrawingAttributes(drawingAttributes);
            }
        }

        private void inkCanvas_PointerMoved(object sender, PointerRoutedEventArgs e)
        {

        }

        private async void saveStroke_Click(object sender, RoutedEventArgs e)
        {
            await saveStrokes();
        }
    }
}
