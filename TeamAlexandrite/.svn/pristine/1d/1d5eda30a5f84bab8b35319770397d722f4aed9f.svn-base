using System;
using System.Collections.Generic;
using System.Collections;
using System.Collections.ObjectModel;
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
using System.IO;

namespace TeamWPF
{
    /// <summary>
    /// Interaction logic for Reports.xaml
    /// </summary>
    public partial class ReportsWindow : Window
    {
        ObservableCollection<Freight> freightGridRows = new ObservableCollection<Freight>();
        public ReportsWindow()
        {
            InitializeComponent();
            ObservableCollection<Enum> customerTypes = new ObservableCollection<Enum>();
            string path =  "../../../CourierManager/ListOfBillOfLadings.txt";
            Freight freight = new Freight(path);
            List<string> allRecords = new List<string>();

            allRecords = freight.AllBills;
            if (allRecords.Count > 0)
            {
                for (int i = 0; i < allRecords.Count; i++)
                {
                    string[] rows = allRecords[i].Split('*');
                    Freight rowfreight = new Freight();
                    rowfreight.State = (FreightState)Enum.Parse(typeof(FreightState), rows[6]);
                    rowfreight.BillOfLading = rows[1];
                   // allfreights.Sender.ClientNumber = Convert.ToInt32(rows[2]);
                    rowfreight.Price = Convert.ToDecimal(rows[4]);                  
                    freightGridRows.Add(rowfreight);
                }
            }
            this.dgFreights.DataContext = freightGridRows;
                //.WriteLine("{0}*{1}*{2}*{3}*{4}*{5}*{6}",
                //    this.AllBills.Count() + 1, this.BillOfLading, this.Sender.ClientNumber,
                //    this.Recipient.ClientNumber, this.Price, this.TariffWeight, this.State);
            
        }

        private void comboboxCustType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var variable = e;
            var selectedItemValue = comboboxCustType.SelectedValue.ToString();
        }

        private void dgFreights_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = (e.Row.GetIndex() + 1).ToString();
        }
    }
}
