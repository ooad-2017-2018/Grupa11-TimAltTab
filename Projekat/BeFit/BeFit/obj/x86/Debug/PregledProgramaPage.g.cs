﻿#pragma checksum "C:\Users\Haris Soljic\Documents\GitHub\Grupa11-TimAltTab\Projekat\BeFit\BeFit\PregledProgramaPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "FBDDF3E36EAE6163B2889C73E43D6FD3"
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
    partial class PregledProgramaPage : 
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
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)(target);
                    #line 8 "..\..\..\PregledProgramaPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Page)element1).Loaded += this.Page_Loaded;
                    #line default
                }
                break;
            case 2:
                {
                    this.NazivProgramaTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3:
                {
                    this.DanTextBlock_Copy = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4:
                {
                    this.danComboBox = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 5:
                {
                    global::Windows.UI.Xaml.Controls.ScrollViewer element5 = (global::Windows.UI.Xaml.Controls.ScrollViewer)(target);
                    #line 14 "..\..\..\PregledProgramaPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.ScrollViewer)element5).ViewChanged += this.ScrollViewer_ViewChanged;
                    #line default
                }
                break;
            case 6:
                {
                    this.vjezbeStackPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
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

