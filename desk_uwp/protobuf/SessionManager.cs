using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using deskx_uwp.protobuf;

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

        public async Task<bool> CreateSession()
        {

            try
            {
                WebGen web = new WebGen("http://localhost:8000/desk/session/create/", "POST", "application/deskdata");
                Request blank = new Request { };
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

        public async Task<bool> JoinSession(int sessionId)
        {
            try
            {
                WebGen web = new WebGen("http://localhost:8000/desk/session/join/", "POST", "application/deskdata");
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
    }
}
