﻿#pragma checksum "c:\users\kosta\documents\visual studio 2015\Projects\desk_uwp\desk_uwp\loginPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "361989156CB6293A19249B27C70AB996"
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
    partial class loginPage : 
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
                    this.textBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 2:
                {
                    this.usernameTextbox = (global::Windows.UI.Xaml.Controls.PasswordBox)(target);
                }
                break;
            case 3:
                {
                    this.passwordTextbox = (global::Windows.UI.Xaml.Controls.PasswordBox)(target);
                }
                break;
            case 4:
                {
                    this.loginButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 17 "..\..\..\loginPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.loginButton).Click += this.loginButton_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.registerButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 6:
                {
                    this.copyright = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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
