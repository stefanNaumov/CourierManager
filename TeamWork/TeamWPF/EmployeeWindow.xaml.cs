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

namespace TeamWPF
{
    /// <summary>
    /// Interaction logic for EmployeeWindow.xaml
    /// </summary>
    public partial class EmployeeWindow : Window
    {
        public EmployeeWindow()
        {
            InitializeComponent();
        }

        private void ProcessEmployeeType(object sender, RoutedEventArgs e)
        {
            CustomerService.Click += (send, even) =>
            {
                DefaultType.Header = CustomerService.Header;
            };
            Driver.Click += (send, even) =>
            {
                DefaultType.Header = Driver.Header;
            };
            Accountant.Click += (send, even) =>
            {
                DefaultType.Header = Accountant.Header;
            };
            Manager.Click += (send, even) =>
            {
                DefaultType.Header = Manager.Header;
            };
        }

        // TODO: add methods to read data
    }
}
