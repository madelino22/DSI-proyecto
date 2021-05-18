using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Core;
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
    public sealed partial class MenuPrincipal : Page
    {
        public MenuPrincipal()
        {
            this.InitializeComponent();
        }

        private void OptionsButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(movilOpciones0));
        }

      

        private void QuitButton_Click(object sender, RoutedEventArgs e)
        {
            CoreApplication.Exit();
        }

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));

        }

        private void NewGameButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));

        }

        override protected void OnNavigatedTo(NavigationEventArgs e)
        {
            switch (App.getIdioma())
            {
                case App.Idiomas.ESPAÑOL:
                    PlayButton.Content = "Jugar";
                    NewGameButton.Content = "N. Partida";
                    OptionsButton.Content = "Opciones";
                    QuitButton.Content = "Salir";
                    break;
                case App.Idiomas.INGLES:
                    PlayButton.Content = "Play";
                    NewGameButton.Content = "New Game";
                    OptionsButton.Content = "Settings";
                    QuitButton.Content = "Exit";
                    break;
                case App.Idiomas.CHINO:
                    PlayButton.Content = "玩";
                    NewGameButton.Content = "新游戏";
                    OptionsButton.Content = "环境";
                    QuitButton.Content = "离开";
                    break;
                case App.Idiomas.JAPONES:
                    PlayButton.Content = "演奏する";
                    NewGameButton.Content = "新しいゲーム";
                    OptionsButton.Content = "設定";
                    QuitButton.Content = "去る";
                    break;
            }
        }
    }
}
