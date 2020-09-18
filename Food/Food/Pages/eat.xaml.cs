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
using Food.models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net;
using Food.Viewsmodels;
using Food.Services;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Food.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class eat : Page
    {
        private productService _ProductService = new productService();
        public eat()
        {
            this.InitializeComponent();
            GetMenu();
            
        }
        public async void GetMenu()
        {

                fooddata list = await _ProductService.todaySpecial();
                gvFood.ItemsSource = list.data;
            
        }

        private void GridView_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            food food = (food)gvFood.SelectedItem;

        }

        private void GridViewItem_RightTapped(object sender, RightTappedRoutedEventArgs e)
        {
            food food = (food)gvFood.SelectedItem;
            foodItem.foodData = food;
            MainPage.mainFrame.Navigate(typeof(thumb1));
        }

        private void GridViewItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            food food = (food)gvFood.SelectedItem;
            foodItem.foodData = food;
            MainPage.mainFrame.Navigate(typeof(thumb1));
        }
    }
}
