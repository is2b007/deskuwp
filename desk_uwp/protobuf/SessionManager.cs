using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using deskx_uwp.protobuf;
using Google.Protobuf.WellKnownTypes;

namespace desk_uwp.protobuf
{
    class SessionManager
    {
        private static SessionManager _instance;

        private SessionManager() { }

        public static SessionManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SessionManager();
                }
                return _instance;
            }
        }

        public static async Task<bool> CreateSession()
        {

            try
            {
                WebGen web = new WebGen(App.Server + "desk/session/create/", "POST", "application/deskdata");
                Session blank = new Session
                {
                    Title = App.SessionName,
                    TimeStart = DateTime.UtcNow.ToTimestamp().ToString()
                };
                await web.SendRequestData(blank);
                MemoryStream mem = await web.GetResponse();
                Session newSession = Session.Parser.ParseFrom(mem.ToArray());
                App.CurrentSession = newSession;
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }

        public static async Task<bool> JoinSession(int sessionId)
        {
            try
            {
                WebGen web = new WebGen(App.Server + "desk/session/join/", "POST", "application/deskdata");
                Session newSession = new Session()
                {
                    Id = sessionId
                };
                await web.SendRequestData(newSession);
                MemoryStream mem = await web.GetResponse();
                Session sourceSession = Session.Parser.ParseFrom(mem.ToArray());
                App.CurrentSession = sourceSession;
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
            
        }

        public static async Task<bool> UpdateSession()
        {
            try
            {
                WebGen web = new WebGen(App.Server + "desk/session/update/", "POST", "application/deskdata");
                Session blank = new Session
                {
                    Id = App.CurrentSession.Id,
                    Title = App.CurrentSession.Title,
                    TimeEnd = DateTime.UtcNow.ToTimestamp().ToString()
                };
                await web.SendRequestData(blank);
                MemoryStream mem = await web.GetResponse();
                Session newSession = Session.Parser.ParseFrom(mem.ToArray());
                return true;
            }
            catch (Exception e)
            {
                Debug.WriteLine("FAILURE");
                return false;
            }
        }
    }
}
