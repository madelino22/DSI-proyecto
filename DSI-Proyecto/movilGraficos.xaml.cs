using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace DSI_Proyecto
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class movilGraficos : Page
    {
        public movilGraficos()
        {
            this.InitializeComponent();
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            App.TryGoBack();
        }
        override protected void OnNavigatedTo(NavigationEventArgs e)
        {
            switch (App.getIdioma())
            {
                case App.Idiomas.ESPAÑOL:
                    PantallaCompletaButton.Content = "Pantalla completa";
                    Resolución.Content = "Resolución";
                    ModoDaltonicoButton.Content = "Modo daltónico";
                    break;
                case App.Idiomas.INGLES:
                    PantallaCompletaButton.Content = "Fullscreen";
                    Resolución.Content = "Resolution";
                    ModoDaltonicoButton.Content = "Color blind Mode";
                    break;
                case App.Idiomas.CHINO:
                    PantallaCompletaButton.Content = "全屏";
                    Resolución.Content = "解析度";
                    ModoDaltonicoButton.Content = "色盲模式";
                    break;
                case App.Idiomas.JAPONES:
                    PantallaCompletaButton.Content = "全画面表示";
                    Resolución.Content = "解決";
                    ModoDaltonicoButton.Content = "色覚異常モード";
                    break;
            }

        }
    }
}
