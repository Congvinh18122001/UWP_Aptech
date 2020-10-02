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
using PRACTICAL.Models;
using System.ServiceModel.Channels;
using System.Windows;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace PRACTICAL.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Login : Page
    {
        public Login()
        {
            this.InitializeComponent();
        }

        private void btnDangKi_Click(object sender, RoutedEventArgs e)
        {
            new UserModel().addAccc(tbUsername.Text, tbPass.Text);

        }

        private void btnDangNhap_Click(object sender, RoutedEventArgs e)
        {
            List<User> users = new UserModel().getUsers();
            bool ischeck = false;
            foreach (User user in users)
            {
                if (user.account.Equals(tbUsername.Text) && user.password.Equals(tbPass.Text))
                {
                    mes.Text = "success";
                    ischeck = true;
                    break;
                }
               
            }
            if (!ischeck)
            {
                mes.Text = "false";
            }
        }
    }
}
