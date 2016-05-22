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
using Windows.ApplicationModel;
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

            WebGen web = new WebGen(App.Server + "desk/session/list/", "POST", "application/deskdata");
            Request blank = new Request {};
            MemoryStream mem = await web.GetResponse();
            var sessionList = SessionList.Parser.ParseFrom(mem.ToArray());
            foreach(var session in sessionList.SessionList_)
            {
                if (String.IsNullOrEmpty(session.TimeEnd))
                {
                    SessionListView.Items?.Add("Session " + session.TimeStart + " started by " + session.Username);
                }
                else
                {
                    ArchivedListView.Items?.Add(session.Title + "Session " + session.TimeStart + " started by " + session.Username);
                }

            }
        }

        private async void addSession_Click(object sender, RoutedEventArgs e)
        {
            var dialogResult = new SessionDialog();
            var result = await dialogResult.ShowAsync();
            if (result != ContentDialogResult.Primary) return;
            var text = dialogResult.Text;
            WebGen web = new WebGen(App.Server + "desk/session/create/", "POST", "application/deskdata");
            Session blank = new Session
            {
                Title = App.SessionName,
            };
            await web.SendRequestData(blank);
            MemoryStream mem = await web.GetResponse();
            Session newSession = Session.Parser.ParseFrom(mem.ToArray());
            App.CurrentSession = newSession;
            this.Frame.Navigate(typeof(DeskView));
        }

        private void JoinSession_Click(object sender, RoutedEventArgs e)
        {

        }

        //        async protected void OnSuspending(object sender, SuspendingEventArgs args)
        //        {
        //            SuspendingDeferral deferral = args.SuspendingOperation.GetDeferral();
        //            await SuspensionManager.SaveAsync();
        //            deferral.Complete();
        //        }
    }
}
