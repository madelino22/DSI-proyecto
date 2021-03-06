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
    public sealed partial class movilIdioma : Page
    {
        public movilIdioma()
        {
            this.InitializeComponent();
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            App.TryGoBack();
        }

        private void chinoButton_Click(object sender, RoutedEventArgs e)
        {
            App.changeIdioma(App.Idiomas.CHINO);
            backButton_Click(sender, e);
        }

        private void españolButton_Click(object sender, RoutedEventArgs e)
        {
            App.changeIdioma(App.Idiomas.ESPAÑOL);
            backButton_Click(sender,e);
        }

        private void inglesButton_Click(object sender, RoutedEventArgs e)
        {
            App.changeIdioma(App.Idiomas.INGLES);
            backButton_Click(sender, e);
        }

        private void japonesButton_Click(object sender, RoutedEventArgs e)
        {
            App.changeIdioma(App.Idiomas.JAPONES);
            backButton_Click(sender, e);
        }
    }
}
