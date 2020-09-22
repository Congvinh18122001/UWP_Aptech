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
        private cartModel cartModel = new cartModel();
        private CartView cart = new CartView();
        private void lvCart_Loaded(object sender, RoutedEventArgs e)
        {
            lvCart.ItemsSource = cartModel.getCartItems();
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

        private void amF_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            CartItem item = lvCart.SelectedItem as CartItem;
            if (item != null)
            {
                
            }
            
        }
    }
}