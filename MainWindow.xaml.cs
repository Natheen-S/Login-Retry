using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Login_Retry
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        string username = "root";
        string password = "root123";
        int retrycount  = 0;
        private void btn_login_Click(object sender, RoutedEventArgs e)
        {
            if (txtbox_username.Text == username && pwdbox_password.Password== password)
            {
                MessageBox.Show("You Have Successfully Logged In", "Login Page", MessageBoxButton.OKCancel, MessageBoxImage.Hand);
            }
            else
            {
                if(retrycount == 0)
                {
                    
                   MessageBoxResult result0 = MessageBox.Show("Invalid Username and Password. Remainning Attempts : 3","Login Page",MessageBoxButton.YesNo,MessageBoxImage.Warning);
                    if(MessageBoxResult.Yes == result0)
                    {
                        retrycount++;
                        txtbox_username.Clear();
                        pwdbox_password.Clear();
                    }

                }
                else if (retrycount == 1)
                {
                    MessageBoxResult result1 = MessageBox.Show("Invalid Username and Password. Remainning Attempts : 2", "Login Page", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                    if (MessageBoxResult.Yes == result1)
                    {
                        retrycount++;
                        txtbox_username.Clear();
                        pwdbox_password.Clear();
                    }
                }
                else if (retrycount == 2)
                {
                    MessageBoxResult result2 = MessageBox.Show("Invalid Username and Password. Remainning Attempts : 1", "Login Page", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                    if (MessageBoxResult.Yes == result2)
                    {
                        retrycount++;
                        txtbox_username.Clear();
                        pwdbox_password.Clear();
                    }
                }
                else if (retrycount >= 3)
                {
                    MessageBox.Show("!Sorry. You ID has been Blocked for too many attempts failed","Login Page",MessageBoxButton.OK,MessageBoxImage.Warning);
                    txtbox_username.Clear();
                    pwdbox_password.Clear();
                    txtbox_username.IsEnabled = false;
                    pwdbox_password.IsEnabled = false;
                }
            }
        }
    }
}
