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
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Food.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Favorite : Page
    {
        public Favorite()
        {
            this.InitializeComponent();
        }
       

        private void ListViewItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            food food = lvCart.SelectedItem as food;

            MainPage.mainFrame.Navigate(typeof(thumb2), food);
        }
        private void lvFav_Loaded(object sender, RoutedEventArgs e)
        {
            lvCart.ItemsSource = Viewsmodels.favoriteView.favoriteList ;
        }

    }
}
