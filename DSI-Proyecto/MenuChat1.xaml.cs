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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace DSI_Proyecto
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>


    public sealed partial class MenuChat1 : Page
    {
        string nombre;

        public MenuChat1()
        {
            this.InitializeComponent();
        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            App.TryGoBack();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter is string &&
             !string.IsNullOrWhiteSpace((string)e.Parameter))
            {
                nombre = e.Parameter.ToString();

                switch (nombre)
                {
                    case "KEKO":
                        Contacto.Source = new BitmapImage(new Uri("ms-appx:///Assets/keko.PNG"));
                        break;
                    case "MARY":
                        Contacto.Source = new BitmapImage(new Uri("ms-appx:///Assets/mary.PNG"));
                        break;
                    case "SECH":
                        Contacto.Source = new BitmapImage(new Uri("ms-appx:///Assets/sech.PNG"));
                        break;
                    case "BOSS":
                        Contacto.Source = new BitmapImage(new Uri("ms-appx:///Assets/dandi.PNG"));
                        break;
                    case "PEPE":
                        Contacto.Source = new BitmapImage(new Uri("ms-appx:///Assets/Pepe.PNG"));
                        break;

                }

                m1.Text += nombre;
            }

            BitmapImage bitmapImage = new BitmapImage();
            if (App.getDaltonismo())
            {
                bitmapImage.UriSource = new Uri(movil.BaseUri, "/Assets/movilchatDaltonismo.PNG");
            }
            else
            {
                bitmapImage.UriSource = new Uri(movil.BaseUri, "/Assets/movilchat.PNG");
            }
            movil.Source = bitmapImage;

        }
        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MenuPausa));
        }
    }
}
