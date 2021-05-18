﻿using System;
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
    }
}
