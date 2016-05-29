using System;
using System.Threading.Tasks;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using desk_uwp.protobuf;

namespace desk_uwp
{

    public sealed partial class LoginPage : Page
    {
        public LoginPage()
        {
            this.InitializeComponent();
        }

        private async void loginButton_Click(object sender, RoutedEventArgs e)
        {
            await Login();   
        }
        private async Task Login()
        {
            if (await AuthManager.Instance.Login(UsernameTextbox.Password, PasswordTextbox.Password))
            {
                this.Frame.Navigate(typeof(SessionView));
            }       
        }

        private async void ServerButton_Click(object sender, RoutedEventArgs e)
        {
//            TO DO IMPLEMENT A VALID URL CHECK
            App.Server = ServerBox.Password;
            var dialog = new MessageDialog("Server succesfully set to: " + App.Server);
            await dialog.ShowAsync();
        }
    }
}
