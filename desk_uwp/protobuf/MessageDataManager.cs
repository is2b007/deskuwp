using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Input.Inking;
using Windows.UI.Xaml.Controls;
using deskx_uwp.protobuf;
using desk_uwp;
using desk_uwp.protobuf;
using Google.Protobuf.WellKnownTypes;

namespace desk_uwp.protobuf
{

    class MessageDataManager
    {
        private ListBox _chatSource;
        bool _done = false;
        private string _lastMessageDate = "NO";

        public MessageDataManager(ListBox source)
        {
            _chatSource = source;
        }

        public async Task SendMessage(string messageSource)
        {
            WebGen web = new WebGen(App.Server + "desk/session/object/store/", "POST", "application/deskdata");
            SessionObject sessionData = new SessionObject
            {
                Session = App.CurrentSession,
                Type = "Message",
                Data = messageSource,
                InsertTime = DateTime.UtcNow.ToTimestamp().ToString(),
            };
            await web.SendRequestData(sessionData);
            MemoryStream mem = await web.GetResponse();
        }

        public void StopTransmitting()
        {
            _done = true;
        }

        public async Task GetMessages()
        {
            while (!_done)
            {
                Session toSend = new Session
                {
                    Id = App.CurrentSession.Id,
                    TimeEnd = _lastMessageDate,
                };
                WebGen web = new WebGen(App.Server + "desk/session/object/get/Message/", "POST", "application/deskdata");
                //            if the last ink date is no it means we haven't actually received anything yet.
                await web.SendRequestData(toSend);
                MemoryStream mem = await web.GetResponse();
                SessionObjectContainer newSession = SessionObjectContainer.Parser.ParseFrom(mem.ToArray());
                if (!(newSession.SessionContainer.Count > 0)) continue;
                var lastObject = newSession.SessionContainer.Last();
                _lastMessageDate = lastObject.InsertTime;

                foreach (var sessionOjbect in newSession.SessionContainer)
                {
                    _chatSource.Items?.Add(sessionOjbect.User + ": " + sessionOjbect.Data);
                }
            }
        }
    }
}
