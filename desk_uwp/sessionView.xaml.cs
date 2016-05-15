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
using Windows.UI.Popups;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace desk_uwp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class sessionView : Page
    {
        public sessionView()
        {
            this.InitializeComponent();
            retrieveSessions();
           
        }
        private async Task retrieveSessions()
        {
            WebRequest webRequest = WebRequest.Create("http://localhost:8000/desk/session/list/");
            webRequest.Credentials = CredentialCache.DefaultCredentials;
            webRequest.Method = "POST";
            webRequest.ContentType = "application/deskdata";

            WebResponse response = await webRequest.GetResponseAsync();
            Stream responseStream = response.GetResponseStream();
            MemoryStream ms = new MemoryStream();
            responseStream.CopyTo(ms);

            SessionList sessionList = SessionList.Parser.ParseFrom(ms.ToArray());
            foreach(Session session in sessionList.SessionList_)
            {
                sessionListView.Items.Add("Session " + session.TimeStart + " started by " + session.Username);
            }
        }

        private async void addSession_Click(object sender, RoutedEventArgs e)
        {
            if (await createSession())
            {
                this.Frame.Navigate(typeof(deskView));
            }
            else
            {
                var dialog = new MessageDialog("FATAL ERROR");
                await dialog.ShowAsync();
            }
           
        }

        private async Task<bool> createSession()
        {
            WebRequest webRequest = WebRequest.Create("http://localhost:8000/desk/session/create/");
            webRequest.Credentials = CredentialCache.DefaultCredentials;
            webRequest.Method = "POST";
            webRequest.ContentType = "application/deskdata";

            WebResponse response = await webRequest.GetResponseAsync();
            Stream responseStream = response.GetResponseStream();
            MemoryStream ms = new MemoryStream();
            responseStream.CopyTo(ms);

            Session newSession = Session.Parser.ParseFrom(ms.ToArray());
            App.CurrentSession = newSession;
            return true;

        }

        private void playbackSession_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
