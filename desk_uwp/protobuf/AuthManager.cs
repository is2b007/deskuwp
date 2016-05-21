using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;
using deskx_uwp.protobuf;

namespace desk_uwp.protobuf
{
    class AuthManager
    {
        private static AuthManager _instance;

        private AuthManager() { }

        public static AuthManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AuthManager();
                }
                return _instance;
            }
        }

        public async Task<bool> Login(string username, string password)
        {
            //Lets do a try and catch with webgen object to request and respond
            try
            {
                //contrusct a webgen object and pass url, content method and content type
                WebGen web = new WebGen("http://localhost:8000/desk/login/", "POST", "application/deskdata");
                Request userData = new Request
                {
                    Username = username,
                    Password = password
                };
                //create a userData request proto and fill it with username and password
                await web.SendRequestData(userData);
                MemoryStream mem = await web.GetResponse();
                //get response from the webgen object and then parse it into a readable protobuf object
                Response authInfo = Response.Parser.ParseFrom(mem.ToArray());
                if (authInfo.Success)
                {
                    return true;
                    //if we returned a success from the response goto next screen
                }
                else
                {
                    //or if we didn't have success lets pring the error we got
                    var dialog = new MessageDialog(authInfo.ErrorMessage);
                    await dialog.ShowAsync();
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
                //Lets return false if we can't connect to server or complete the web request
                var dialog = new MessageDialog("Can't connect to Server.");
                await dialog.ShowAsync();
            }
            return false;
        }

    }
}
