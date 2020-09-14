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
using Assignment.Models;
using Assignment.ViewModels;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Assignment.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class mailListPage : Page
    {
        public mailListPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Assignment3.contentFrame.Navigate(typeof(MailPage));
        }

        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            Mail mail = (Mail)LV.SelectedItem;
            MailView.mailList.Remove(mail);
            Assignment3.contentFrame.Navigate(typeof(mailListPage));
        }

        private void LV_Loaded(object sender, RoutedEventArgs e)
        {
            LV.ItemsSource = new MailView().Mails;
        }
    }
}
