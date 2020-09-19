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
using Food.Viewsmodels;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Food.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class thumb2 : Page
    {
        private foodService service = new foodService();
        public thumb2()
        {
            this.InitializeComponent();
        }
        private food food { get; set; }
        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            food = e.Parameter as food;
            foodDetail f = await service.todaySpecial(food.id);
            ButtonBack.IsEnabled = this.Frame.CanGoBack;
            food = f.data;
        }
        private void lvItem_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        }
        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            if (this.Frame.CanGoBack)
            {
                this.Frame.GoBack();
            }
        }
    }
}
