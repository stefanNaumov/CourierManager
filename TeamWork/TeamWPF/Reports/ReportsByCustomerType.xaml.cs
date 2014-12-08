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

namespace TeamWPF.Reports
{
    /// <summary>
    /// Interaction logic for ReportsByCustomerType.xaml
    /// </summary>
    public partial class ReportsByCustomerType : Window
    {
        public ReportsByCustomerType()
        {
            InitializeComponent();
        }

        private void cmbxCustomerType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var variable = e;
            var selectedItemValue = cmbxCustomerType.SelectedValue.ToString();
        }

        private void freightsDG_LoadingRow(object sender, DataGridRowEventArgs e)
        {

        }

    }
}
