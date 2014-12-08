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
using System.Windows.Shapes;
using CourierManager;

namespace TeamWPF
{
    /// <summary>
    /// Interaction logic for Logging.xaml
    /// </summary>
    public partial class Logging : Window
    {
        public Logging()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            if (UsernameBox.Text=="team"&&PasswordBox.Text=="team")
            {
                
                var currentLogger = Logger.CurrentLogger;
                WelcomeWindow welcome = new WelcomeWindow();
                welcome.WelcomeBlock.Text = String.Format("Welcome, {0} !\nClick \"OK\" to begin.", UsernameBox.Text);
                this.Close();
                welcome.Show();
            }

            else
            {
                ErrorWindow invalidUserOrPass = new ErrorWindow();
                invalidUserOrPass.ErrorText.Text="Invalid username or password";
                //invalidUserOrPass.ErrorText.TextAlignment=TextAlignment.
                invalidUserOrPass.Show();
                UsernameBox.Text = String.Empty;
                PasswordBox.Text = String.Empty;
            }
        }
    }
}
