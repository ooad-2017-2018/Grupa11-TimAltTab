﻿#pragma checksum "C:\Users\emins\Documents\GitHub\Grupa11-TimAltTab\Projekat\BeFit\BeFit\View\ProgramControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B8F82390DA862A615B8F0AC5B28F247A"
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
    partial class ProgramControl : 
        global::Windows.UI.Xaml.Controls.UserControl, 
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
                    global::Windows.UI.Xaml.Controls.UserControl element1 = (global::Windows.UI.Xaml.Controls.UserControl)(target);
                    #line 11 "..\..\..\View\ProgramControl.xaml"
                    ((global::Windows.UI.Xaml.Controls.UserControl)element1).Tapped += this.UserControl_Tapped;
                    #line default
                }
                break;
            case 2:
                {
                    this.nazivProgramaTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3:
                {
                    this.tezinaProgramaTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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

