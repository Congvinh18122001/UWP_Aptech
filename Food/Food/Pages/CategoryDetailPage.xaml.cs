using Food.models;
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
using Food.Services;
using Food.models;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Food.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CategoryDetailPage : Page
    {
        private categoryDetailService service = new categoryDetailService();
        public CategoryDetailPage()
        {
            this.InitializeComponent();
        }
        private MenuItem Item { get; set; }
        private List<food> foodList = new List<food>();
        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            Item = e.Parameter as MenuItem;
            ButtonBack.IsEnabled = this.Frame.CanGoBack;

            CatModel foods = await service.todaySpecial(Item.id);
            foodList = foods.data.foods;
            gvFood.ItemsSource = foodList;
        }

        private void GridViewItem_RightTapped(object sender, RightTappedRoutedEventArgs e)
        {

        }

        private void GridViewItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            food food = gvFood.SelectedItem as food;

            MainPage.mainFrame.Navigate(typeof(thumb2),food);
        }

        private void GridView_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            if (this.Frame.CanGoBack)
            {
                this.Frame.GoBack();
            }
        }

        private void s1_Checked(object sender, RoutedEventArgs e)
        {
            var PersonListSort = foodList.OrderBy(P => P.price);
            gvFood.ItemsSource = PersonListSort;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            var PersonListSort = foodList.OrderBy(P => P.name);
            gvFood.ItemsSource = PersonListSort;
        }

        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            var search = new List<food>();
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                gvFood.ItemsSource = foodList;
            }
            else
            {
                foreach (food food in foodList)
                {
                    if (food.name.Contains(txtSearch.Text))
                    {
                        search.Add(food);
                    }
                }
                gvFood.ItemsSource = search;
            }
            
        }
    }
}
