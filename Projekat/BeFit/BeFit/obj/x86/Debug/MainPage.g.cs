﻿#pragma checksum "C:\Users\emins\Documents\GitHub\Grupa11-TimAltTab\Projekat\BeFit\BeFit\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "829CEB8A9067BD25BF233D8F63825AEB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BeFit
{
    partial class MainPage : 
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
                    this.VisualStateGroup = (global::Windows.UI.Xaml.VisualStateGroup)(target);
                }
                break;
            case 2:
                {
                    this.Phone = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 3:
                {
                    this.Tablet = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 4:
                {
                    this.Desktop = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 5:
                {
                    this.kanvas = (global::Windows.UI.Xaml.Controls.Canvas)(target);
                }
                break;
            case 6:
                {
                    this.BeFit = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 7:
                {
                    this.bzvz = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 8:
                {
                    this.stek = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 9:
                {
                    this.loginButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 59 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.loginButton).Click += this.loginButton_Click;
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

