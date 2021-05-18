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
    public sealed partial class movilOpciones0 : Page
    {
        public movilOpciones0()
        {
            this.InitializeComponent();
        }

        private void IdiomaButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(movilIdioma));
        }

        private void GraficosButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(movilGraficos));
        }

        private void salirButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MenuPrincipal));
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
                    IdiomaButton.Content = "Idioma";
                    GraficosButton.Content = "Gráficos";
                    salirButton.Content = "Salir";
                    break;
                case App.Idiomas.INGLES:
                    IdiomaButton.Content = "Language";
                    GraficosButton.Content = "Video";
                    salirButton.Content = "Quit";
                    break;
                case App.Idiomas.CHINO:
                    IdiomaButton.Content = "成语";
                    GraficosButton.Content = "图形";
                    salirButton.Content = "离开";
                    break;
                case App.Idiomas.JAPONES:
                    IdiomaButton.Content = "熟語";
                    GraficosButton.Content = "グラフィック";
                    salirButton.Content = "去る";
                    break;
            }
            
        }
    }
}
