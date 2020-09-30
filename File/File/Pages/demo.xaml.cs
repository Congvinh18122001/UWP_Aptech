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
using Windows.Storage;
using File.Services;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace File.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class demo : Page
    {
        public demo()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FileHandleService.WriteFile("uwpNoteFile.txt",txtContent.Text);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            txtContent.Text = "";
        }

        private async void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string txt = await FileHandleService.ReadFile("uwpNoteFile.txt");
            FileHandleService.ExportFile("Filename",txt);
        }
    }
}
