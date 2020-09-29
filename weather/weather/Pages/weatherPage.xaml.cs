using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using weather.Models;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using weather.Services;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace weather.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class weatherPage : Page
    {
        public weatherPage()
        {
            this.InitializeComponent();
        }
        private weatherSevices services = new weatherSevices();
        private Root root;
        private  void Grid_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private async void ListView_Loaded(object sender, RoutedEventArgs e)
        {
            root = await services.todaySpecial();
            LV.Items.Add(root); 
        }

    }
}
