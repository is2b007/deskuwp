﻿#pragma checksum "C:\Users\Kosta\Documents\Visual Studio 2015\Projects\deskuwp\desk_uwp\sessionView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0EC87A7CC900DA689200A1DB166BA02C"
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
    partial class sessionView : 
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
                    this.addSession = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 15 "..\..\..\sessionView.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.addSession).Click += this.addSession_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.copyright = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4:
                {
                    this.sessionListView = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 5:
                {
                    this.playbackSession = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 18 "..\..\..\sessionView.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.playbackSession).Click += this.playbackSession_Click;
                    #line default
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

