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
using System.Net.Http;
using Newtonsoft.Json;
using System.Net;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Food.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private readonly string stringUrl = string.Format("https://foodgroup.herokuapp.com/api/menu");
        public static Frame mainFrame;
        public MainPage()
        {
            this.InitializeComponent();
            GetMenu();
        }
        public async void GetMenu()
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync(stringUrl);
            List<MenuItem> Menus = new List<MenuItem>();
                if (response.StatusCode == HttpStatusCode.OK)
            {
                var stringContent = await response.Content.ReadAsStringAsync();
                Menu list = JsonConvert.DeserializeObject<Menu>(stringContent);
                Menus = list.data;
            }
            List<MenuItem> menus = new List<MenuItem>();
            menus.Add(new MenuItem(16, "https://bit.ly/2REFwxV", "Home"));
            foreach (MenuItem item in Menus)
            {
                menus.Add(item);
            }
            menus.Add(new MenuItem(15, "https://bit.ly/3cbxne3", "Cart"));
            menus.Add(new MenuItem(14, "https://bit.ly/2RIu8Ba", "Favorite"));

            lvMenu.ItemsSource = menus;
        }
        private void Menu_Loaded(object sender, RoutedEventArgs e)
        {
          
        }

        private void Menu_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MenuItem menuItem = lvMenu.SelectedItem as MenuItem;
            if (menuItem.id == 16)
            {
                MainFrame.Navigate(typeof(eat));
            }
            else if (menuItem.id == 15)
            {
                MainFrame.Navigate(typeof(Cart));
            }
            else if (menuItem.id == 14)
            {
                MainFrame.Navigate(typeof(Favorite));
            }
            else {
                MainFrame.Navigate(typeof(CategoryDetailPage), menuItem);
            }
           
        }

        private void MainFrame_Loaded(object sender, RoutedEventArgs e)
        {
            mainFrame = MainFrame;
            MainFrame.Navigate(typeof(eat));
        }
    }
}
