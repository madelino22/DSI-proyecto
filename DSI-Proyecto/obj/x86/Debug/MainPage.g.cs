﻿#pragma checksum "C:\Users\MASTER\Desktop\DSI-proyecto\DSI-Proyecto\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2A2D3048FD5AB0FCB42B5671C465C24C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DSI_Proyecto
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 24
                {
                    global::Windows.UI.Xaml.Controls.Grid element2 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    ((global::Windows.UI.Xaml.Controls.Grid)element2).PointerReleased += this.Grid_PointerReleased;
                }
                break;
            case 3: // MainPage.xaml line 100
                {
                    this.strike1 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 4: // MainPage.xaml line 101
                {
                    this.strike2 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 5: // MainPage.xaml line 102
                {
                    this.strike3 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 6: // MainPage.xaml line 91
                {
                    global::Windows.UI.Xaml.Controls.Image element6 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)element6).PointerPressed += this.Image_PointerPressed_1;
                    ((global::Windows.UI.Xaml.Controls.Image)element6).PointerReleased += this.Image_PointerReleased_1;
                }
                break;
            case 7: // MainPage.xaml line 92
                {
                    global::Windows.UI.Xaml.Controls.Image element7 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)element7).PointerPressed += this.Image_PointerPressed;
                    ((global::Windows.UI.Xaml.Controls.Image)element7).PointerReleased += this.Image_PointerReleased;
                }
                break;
            case 8: // MainPage.xaml line 66
                {
                    this.MiCanvas = (global::Windows.UI.Xaml.Controls.Canvas)(target);
                    ((global::Windows.UI.Xaml.Controls.Canvas)this.MiCanvas).PointerReleased += this.LibroCentro_PointerReleased;
                }
                break;
            case 9: // MainPage.xaml line 68
                {
                    this.LibroCentro = (global::Windows.UI.Xaml.Controls.ContentControl)(target);
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.LibroCentro).PointerMoved += this.LibroCentro_PointerMoved;
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.LibroCentro).PointerPressed += this.LibroCentro_PointerPressed;
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.LibroCentro).PointerReleased += this.LibroCentro_PointerReleased;
                }
                break;
            case 10: // MainPage.xaml line 79
                {
                    this.DNIcentro = (global::Windows.UI.Xaml.Controls.ContentControl)(target);
                }
                break;
            case 11: // MainPage.xaml line 71
                {
                    this.VestimentaButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.VestimentaButton).Click += this.Button_Click;
                }
                break;
            case 12: // MainPage.xaml line 72
                {
                    this.ObjetosButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.ObjetosButton).Click += this.Button_Click_1;
                }
                break;
            case 13: // MainPage.xaml line 73
                {
                    this.DocumentationButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.DocumentationButton).Click += this.Button_Click_2;
                }
                break;
            case 14: // MainPage.xaml line 74
                {
                    this.DrunkButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.DrunkButton).Click += this.Button_Click_3;
                }
                break;
            case 15: // MainPage.xaml line 75
                {
                    this.Normas = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 16: // MainPage.xaml line 57
                {
                    this.AceptarButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.AceptarButton).Click += this.AceptarButton_Click;
                }
                break;
            case 17: // MainPage.xaml line 59
                {
                    this.RechazarButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 18: // MainPage.xaml line 54
                {
                    this.CachearButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 19: // MainPage.xaml line 55
                {
                    this.DNIButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.DNIButton).Click += this.DNIButton_Click;
                }
                break;
            case 20: // MainPage.xaml line 45
                {
                    this.dineroTex = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

