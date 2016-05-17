﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using deskx_uwp.protobuf;
using Google.Protobuf;
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
            //Lets do a try and catch with webgen object to request and respond
            try
            {
            //contrusct a webgen object and pass url, content method and content type
                WebGen web = new WebGen("http://localhost:8000/desk/login/", "POST", "application/deskdata");
                Request userData = new Request
                {
                    Username = UsernameTextbox.Password,
                    Password = PasswordTextbox.Password
                };
                //create a userData request proto and fill it with username and password
                await web.SendRequestData(userData);
                MemoryStream mem = await web.GetResponse();
                //get response from the webgen object and then parse it into a readable protobuf object
                Response authInfo = Response.Parser.ParseFrom(mem.ToArray());
                if (authInfo.Success == true)
                {
                    this.Frame.Navigate(typeof(SessionView));
                    //if we returned a success from the response goto next screen
                }
                else
                {
                    //or if we didn't have success lets pring the error we got
                    var dialog = new MessageDialog(authInfo.ErrorMessage);
                    await dialog.ShowAsync();
                }
            }
            catch(Exception e)
            {
                Debug.WriteLine(e.ToString());
                //Lets return false if we can't connect to server or complete the web request
                var dialog = new MessageDialog("Can't connect to Server.");
                await dialog.ShowAsync();
            }            
        }
    }
}
