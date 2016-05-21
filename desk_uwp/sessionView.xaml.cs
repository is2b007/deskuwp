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
using desk_uwp.protobuf;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace desk_uwp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SessionView : Page
    {
        public SessionView()
        {
            this.InitializeComponent();
            OnLoad();
        }

        public async void OnLoad()
        {
            await RetrieveSessions();
        }
        private async Task RetrieveSessions()
        {

            WebGen web = new WebGen("http://localhost:8000/desk/session/list/", "POST", "application/deskdata");
            Request blank = new Request {};
            MemoryStream mem = await web.GetResponse();
            var sessionList = SessionList.Parser.ParseFrom(mem.ToArray());
            foreach(var session in sessionList.SessionList_)
            {
                SessionListView.Items?.Add("Session " + session.TimeStart + " started by " + session.Username);
            }
        }

        private async void addSession_Click(object sender, RoutedEventArgs e)
        {
            if (await CreateSession())
            {
                this.Frame.Navigate(typeof(DeskView));
            }
            else
            {
                var dialog = new MessageDialog("FATAL ERROR");
                await dialog.ShowAsync();
            }
           
        }

        private static async Task<bool> CreateSession()
        {
            WebGen web = new WebGen("http://localhost:8000/desk/session/create/", "POST", "application/deskdata");
            Request blank = new Request { };
            MemoryStream mem = await web.GetResponse();
            Session newSession = Session.Parser.ParseFrom(mem.ToArray());
            App.CurrentSession = newSession;
            return true;

        }

        private void playbackSession_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
