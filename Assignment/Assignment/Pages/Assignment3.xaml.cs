using Assignment.Models;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Assignment.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Assignment3 : Page
    {
        public static Frame contentFrame;
        public Assignment3()
        {
            this.InitializeComponent();
        }

        private void ScrollViewer_Loaded(object sender, RoutedEventArgs e)
        {
            contentFrame = frMenu;
        }

        private void ListView_Loaded(object sender, RoutedEventArgs e)
        {
            LV.Items.Add(new item("home",(char)(Convert.ToInt32("E80F", 16)), "Home"));
            LV.Items.Add(new item("contact", (char)(Convert.ToInt32("E779", 16)), "Contact"));
            LV.Items.Add(new item("customer", (char)(Convert.ToInt32("E77B", 16)), "Customer"));
            LV.Items.Add(new item("mail", (char)(Convert.ToInt32("E715", 16)), "Mail"));

        }

        private void ScrollViewer_Tapped(object sender, TappedRoutedEventArgs e)
        {
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            slvMenu.IsPaneOpen = !slvMenu.IsPaneOpen;
        }

        private void LV_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

        private void ListViewItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            item item = (item)LV.SelectedItem;
            if (item.Dest.Equals("contact"))
            {
                frMenu.Navigate(typeof(Asignment2));
            }
            else if (item.Dest.Equals("customer"))
            {
                frMenu.Navigate(typeof(CustomerPage));
            }
            else if (item.Dest.Equals("mail"))
            {
                frMenu.Navigate(typeof(MailPage));
            }
        }
    }
}
