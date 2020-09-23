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
using Food.Viewsmodels;
using Food.models;
using SQLitePCL;
using Food.Adapters;
using Food.Services;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Food.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Cart : Page
    {
        public Cart()
        {
            this.InitializeComponent();
        }
        private string total;
        private cartModel cartModel = new cartModel();
        private CartView cart = new CartView();
        private void lvCart_Loaded(object sender, RoutedEventArgs e)
        {
            lvCart.ItemsSource = cartModel.getCartItems();
            var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
            if (cartModel.getCartItems().Count > 0)
            {
                int t = 0;
                foreach (CartItem item in cartModel.getCartItems())
                {
                    t += item.amount * item.price;
                }
                total =  String.Format(info, "{0:c}", t);
            }
            else
            {
                total = String.Format(info, "{0:c}", 0); 
            }
        }

        private void HyperlinkButton_Tapped(object sender, TappedRoutedEventArgs e)
        {

            CartItem item = lvCart.SelectedItem as CartItem;
            if (item != null)
            {
                cartModel.deleteCartItem(item.id);
            }
            MainPage.mainFrame.Navigate(typeof(Cart));
        }

        private async void imgF_Tapped(object sender, TappedRoutedEventArgs e)
        {
             
            CartItem cartItem = lvCart.SelectedItem as CartItem;
            foodDetail f = await new foodService().todaySpecial(cartItem.foodId);
            food food = f.data;
            MainPage.mainFrame.Navigate(typeof(thumb2), food);
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            cartModel.clearCart();
            MainPage.mainFrame.Navigate(typeof(Cart));
        }

        private void RelativePanel_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void amF_TextChanged(object sender, TextChangedEventArgs e)
        {
            var TextBox = sender as TextBox;

            CartItem item = TextBox.Tag as CartItem;
            if (item != null && !string.IsNullOrEmpty(TextBox.Text) )
            {
                cartModel.updateAmount(item.id, Int32.Parse(TextBox.Text));
                MainPage.mainFrame.Navigate(typeof(Cart));
            }
        }
    }
}