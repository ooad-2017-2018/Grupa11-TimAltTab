﻿#pragma checksum "C:\Users\Haris Soljic\Documents\GitHub\Grupa11-TimAltTab\Projekat\BeFit\BeFit\View\KlijentHomePage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D33715BA701B6500813BC5A1284DE578"
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
    partial class KlijentHomePage : 
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
                    this.NavView = (global::Windows.UI.Xaml.Controls.NavigationView)(target);
                    #line 11 "..\..\..\View\KlijentHomePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.NavigationView)this.NavView).ItemInvoked += this.NavView_ItemInvoked;
                    #line 12 "..\..\..\View\KlijentHomePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.NavigationView)this.NavView).Loaded += this.NavView_Loaded;
                    #line default
                }
                break;
            case 2:
                {
                    this.ContentFrame = (global::Windows.UI.Xaml.Controls.Frame)(target);
                    #line 25 "..\..\..\View\KlijentHomePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Frame)this.ContentFrame).Navigated += this.HomePageNavigated;
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

