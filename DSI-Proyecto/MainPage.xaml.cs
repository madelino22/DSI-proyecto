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
        int strike = 0;
        int dinero = 0;
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
            if (movilClick) this.Frame.Navigate(typeof(MenuPausa));

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
                if (e.GetCurrentPoint(MiCanvas).Properties.IsLeftButtonPressed) botIzq = true;
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
                    ObjetosButton.Content = "Objetos ilegales";
                    DocumentationButton.Content = "Documentación";
                    DrunkButton.Content = "Embriaguez";
                    break;
                case App.Idiomas.INGLES:
                    CachearButton.Content = "Search";
                    DNIButton.Content = "Ask for ID";
                    AceptarButton.Content = "Accept";
                    RechazarButton.Content = "Reject";
                    VestimentaButton.Content = "Clothing";
                    ObjetosButton.Content = "Illegal objects";
                    DocumentationButton.Content = "Documentation";
                    DrunkButton.Content = "Drunkenness";
                    break;
                case App.Idiomas.CHINO:
                    CachearButton.Content = "搜索";
                    DNIButton.Content = "索取身份证";
                    AceptarButton.Content = "接受";
                    RechazarButton.Content = "拒绝";
                    VestimentaButton.Content = "服装";
                    ObjetosButton.Content = "非法物品";
                    DocumentationButton.Content = "文件资料";
                    DrunkButton.Content = "酒醉";
                    break;
                case App.Idiomas.JAPONES:
                    CachearButton.Content = "探す";
                    DNIButton.Content = "IDを要求する";
                    AceptarButton.Content = "受け入れるために";
                    RechazarButton.Content = "拒否する";
                    VestimentaButton.Content = "衣類";
                    ObjetosButton.Content = "違法なオブジェクト";
                    DocumentationButton.Content = "ドキュメンテーション";
                    DrunkButton.Content = "酩酊";
                    break;
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            switch (App.getIdioma())
            {
                case App.Idiomas.ESPAÑOL:
                    Normas.Text = "- Prohibido zapatillas o chanclas, ropa informal u ofensiva para el local.";
                    break;
                case App.Idiomas.INGLES:
                    Normas.Text = "- Forbidden slippers or flip flops, informal or offensive clothing for the disco.";
                    break;
                case App.Idiomas.CHINO:
                    Normas.Text = "- 处所内严禁穿拖鞋或人字拖鞋，非正式或令人反感的衣服。";
                    break;
                case App.Idiomas.JAPONES:
                    Normas.Text = "- 禁止されているスリッパまたはビーチサンダル、敷地内の非公式または不快な衣服。";
                    break;
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            switch (App.getIdioma())
            {
                case App.Idiomas.ESPAÑOL:
                    Normas.Text = "- Cualquier objeto que pueda afectar a clientes y personal estará prohibido, como drogas y armas.";
                    break;
                case App.Idiomas.INGLES:
                    Normas.Text = "- Any object that could affect clients and staff will be prohibited, such as drugs and weapons.";
                    break;
                case App.Idiomas.CHINO:
                    Normas.Text = "- 禁止使用任何可能影响客户和员工的物品，例如毒品和武器。";
                    break;
                case App.Idiomas.JAPONES:
                    Normas.Text = "- 薬物や武器など、クライアントやスタッフに影響を与える可能性のあるオブジェクトは禁止されます。";
                    break;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            switch (App.getIdioma())
            {
                case App.Idiomas.ESPAÑOL:
                    Normas.Text = "- Prohibida la entrada a cualquiera persona menor de 16 años o que no lleve documentación en regla.";
                    break;
                case App.Idiomas.INGLES:
                    Normas.Text = "- Entry is prohibited to anyone under 16 years of age or who does not carry proper documentation.";
                    break;
                case App.Idiomas.CHINO:
                    Normas.Text = "- 禁止任何未满16周岁或未携带适当证件的人入境。";
                    break;
                case App.Idiomas.JAPONES:
                    Normas.Text = "- 16歳未満の方、または適切な書類を所持していない方の立ち入りは禁止されています。";
                    break;
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            switch (App.getIdioma())
            {
                case App.Idiomas.ESPAÑOL:
                    Normas.Text = "- Cualquier persona que esté en estado de embriaguez severo, no podrá entrar al local.";
                    break;
                case App.Idiomas.INGLES:
                    Normas.Text = "- Any person who is in a state of severe intoxication, will not be able to enter the disco.";
                    break;
                case App.Idiomas.CHINO:
                    Normas.Text = "- 处于严重中毒状态的任何人将无法进入房屋。";
                    break;
                case App.Idiomas.JAPONES:
                    Normas.Text = "- 重度の中毒状態にある人は、敷地内に立ち入ることができません。";
                    break;
            }
        }

        private void strikeFunc()
        {
            strike++;
            if (strike == 1) strike1.Opacity = 0;
            else if (strike == 2) strike2.Opacity = 0;
            else if (strike == 3) strike3.Opacity = 0;
        }

        private void AceptarButton_Click(object sender, RoutedEventArgs e)
        {
            if (strike == 3) return;
            Random rnd = new Random();
            int s = rnd.Next(0, 5);
            if (s == 4)
                strikeFunc();
            else
            {
                dinero += 100;
                dineroTex.Text = dinero + "$";
            }
        }

        private void DNIButton_Click(object sender, RoutedEventArgs e)
        {
            if (DNIcentro.Opacity==0)
            {
                DNIcentro.Opacity = 1;
            }
            else DNIcentro.Opacity = 0;
        }
    }
}
