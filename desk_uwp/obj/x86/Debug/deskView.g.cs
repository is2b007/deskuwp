﻿#pragma checksum "C:\Users\Kosta\Documents\Visual Studio 2015\Projects\deskuwp\desk_uwp\deskView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "54A651A019C683A9EA9D3FA255E04290"
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
    partial class DeskView : 
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
                    this.saveStroke = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 15 "..\..\..\deskView.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.saveStroke).Click += this.saveStroke_Click;
                    #line default
                }
                break;
            case 2:
                {
                    this.viewInk = (global::Windows.UI.Xaml.Controls.Viewbox)(target);
                }
                break;
            case 3:
                {
                    this.HeaderPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 4:
                {
                    this.Header = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5:
                {
                    this.PenColor = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    #line 45 "..\..\..\deskView.xaml"
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.PenColor).SelectionChanged += this.OnPenColorChanged;
                    #line default
                }
                break;
            case 6:
                {
                    this.inkCanvas = (global::Windows.UI.Xaml.Controls.InkCanvas)(target);
                    #line 23 "..\..\..\deskView.xaml"
                    ((global::Windows.UI.Xaml.Controls.InkCanvas)this.inkCanvas).PointerMoved += this.inkCanvas_PointerMoved;
                    #line 23 "..\..\..\deskView.xaml"
                    ((global::Windows.UI.Xaml.Controls.InkCanvas)this.inkCanvas).Loaded += this.inkCanvas_Loaded;
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

