using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace DSI_Proyecto
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        bool movilClick = false;
        bool libroClick = false;
        bool botIzq = false;
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Image_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            movilClick = true;
        }

        private void Image_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            if(movilClick) this.Frame.Navigate(typeof(MenuPausa));

            movilClick = false;
        }

        private void Grid_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            movilClick = false;
            libroClick = false;

        }

        private void Image_PointerPressed_1(object sender, PointerRoutedEventArgs e)
        {
            libroClick = true;
        }

        private void Image_PointerReleased_1(object sender, PointerRoutedEventArgs e)
        {
            if (libroClick)
            {
                if (LibroCentro.Visibility == Visibility.Collapsed) LibroCentro.Visibility = Visibility.Visible;
                else if (LibroCentro.Visibility == Visibility.Visible) LibroCentro.Visibility = Visibility.Collapsed;
            }
            libroClick = false;
        }

        private void LibroCentro_PointerMoved(object sender, PointerRoutedEventArgs e)
        {
            if (LibroCentro.Visibility == Visibility.Visible)
            {
                PointerPoint NewptrPt = e.GetCurrentPoint(MiCanvas);
                if (botIzq)
                {
                    LibroCentro.SetValue(Canvas.TopProperty, NewptrPt.Position.Y - 150);
                    LibroCentro.SetValue(Canvas.LeftProperty, NewptrPt.Position.X - 280);
                }
            }
        }

        private void LibroCentro_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            if (LibroCentro.Visibility == Visibility.Visible)
            {
                if(e.GetCurrentPoint(MiCanvas).Properties.IsLeftButtonPressed) botIzq = true;
            }
        }

        private void LibroCentro_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            if (LibroCentro.Visibility == Visibility.Visible)
            {
                botIzq = false;
            }
        }

        override protected void OnNavigatedTo(NavigationEventArgs e)
        {
            switch (App.getIdioma())
            {
                case App.Idiomas.ESPAÑOL:
                    CachearButton.Content = "Cachear";
                    DNIButton.Content = "Pedir DNI";
                    AceptarButton.Content = "Aceptar";
                    RechazarButton.Content = "Rechazar";
                    VestimentaButton.Content = "Vestimenta";
                    break;
                case App.Idiomas.INGLES:
                    CachearButton.Content = "Search";
                    DNIButton.Content = "Ask for ID";
                    AceptarButton.Content = "Accept";
                    RechazarButton.Content = "Reject";
                    VestimentaButton.Content = "Clothing";
                    break;
                case App.Idiomas.CHINO:
                    CachearButton.Content = "搜索";
                    DNIButton.Content = "索取身份证";
                    AceptarButton.Content = "接受";
                    RechazarButton.Content = "拒绝";
                    VestimentaButton.Content = "服装";
                    break;
                case App.Idiomas.JAPONES:
                    CachearButton.Content = "探す";
                    DNIButton.Content = "IDを要求する";
                    AceptarButton.Content = "受け入れるために";
                    RechazarButton.Content = "拒否する";
                    VestimentaButton.Content = "衣類";
                    break;
            }

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Normas.Text = "- Prohibido zapatillas o chanclas, ropa informal u ofensiva para el local.";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Normas.Text = "- Cualquier objeto que pueda afectar a clientes y personal estará prohibido, como drogas y armas.";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Normas.Text = "- Prohibida la entrada a cualquiera persona menor de 16 años o que no lleve documentación en regla.";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Normas.Text = "- Cualquier persona que esté en estado de embriaguez severo, no podrá entrar al local.";
        }
    }
}
