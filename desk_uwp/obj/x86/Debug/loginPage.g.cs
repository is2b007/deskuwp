﻿#pragma checksum "C:\Users\Kosta\Documents\GitHub\deskuwp\desk_uwp\loginPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "721C1014BA3DF6D24611B6D3FB055E43"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace desk_uwp
{
    partial class LoginPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.TextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 2:
                {
                    this.UsernameTextbox = (global::Windows.UI.Xaml.Controls.PasswordBox)(target);
                }
                break;
            case 3:
                {
                    this.PasswordTextbox = (global::Windows.UI.Xaml.Controls.PasswordBox)(target);
                }
                break;
            case 4:
                {
                    this.LoginButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 17 "..\..\..\loginPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.LoginButton).Click += this.loginButton_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.RegisterButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 6:
                {
                    this.Copyright = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7:
                {
                    this.ServerButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 20 "..\..\..\loginPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.ServerButton).Click += this.ServerButton_Click;
                    #line default
                }
                break;
            case 8:
                {
                    this.ServerBox = (global::Windows.UI.Xaml.Controls.PasswordBox)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

