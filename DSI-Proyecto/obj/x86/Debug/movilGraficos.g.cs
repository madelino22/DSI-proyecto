﻿#pragma checksum "C:\Users\roy_x\OneDrive\Escritorio\GitHub\DSI-proyecto\DSI-Proyecto\movilGraficos.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "54A97A94C8A6559C16FC0020D6C69883"
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
    partial class movilGraficos : 
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
            case 2: // movilGraficos.xaml line 28
                {
                    this.movilGraficosImagen = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 3: // movilGraficos.xaml line 29
                {
                    this.viewBox = (global::Windows.UI.Xaml.Controls.Viewbox)(target);
                }
                break;
            case 4: // movilGraficos.xaml line 40
                {
                    this.backButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.backButton).Click += this.backButton_Click;
                }
                break;
            case 5: // movilGraficos.xaml line 42
                {
                    this.panelOpciones = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 6: // movilGraficos.xaml line 47
                {
                    this.panelImagenes = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 7: // movilGraficos.xaml line 43
                {
                    this.PantallaCompletaButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 8: // movilGraficos.xaml line 44
                {
                    this.Resolución = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 9: // movilGraficos.xaml line 45
                {
                    this.ModoDaltonicoButton = (global::Windows.UI.Xaml.Controls.Button)(target);
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

