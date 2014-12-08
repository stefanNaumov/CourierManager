using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for FreightWindow.xaml
    /// </summary>
    public partial class CompanyWindow : Window
    {
        private bool isWindowClosing = false;

        private CourierManager.CompanyCustomer senderCompany;
        private CourierManager.Customer recepient;
        public CompanyWindow()
        {
            InitializeComponent();
        }

        public void OnCloseCompanyWindow(object sender, CancelEventArgs e)
        {
            isWindowClosing = true;
        }

        private void ProcesssCompanyStatute(object sender, RoutedEventArgs e)
        {
            NewClient.Click += (send, even) =>
                {
                    DefaultStatute.Header = NewClient.Header;
                };
            VIPClient.Click += (send, even) =>
                {
                    DefaultStatute.Header = VIPClient.Header;
                };
            ClientWithPreferences.Click += (send, even) =>
                {
                    DefaultStatute.Header = ClientWithPreferences.Header;
                };
        }

        private void CompanyIDNumberLostFocus(object sender, RoutedEventArgs e)
        {
            try
            {
                CourierManager.ValidatorIDNumber.ValidateCompanyIDNumber(this.CompanyIDNumberInput.Text);
                CourierManager.CompanyCustomer tempCustomer =
               new CourierManager.CompanyCustomer(ulong.Parse(this.CompanyIDNumberInput.Text));
                tempCustomer.PathToDatabase = "../../../CourierManager/CompanyCustomers.txt";
                List<string> allCompanyClients = tempCustomer.ReadClientData();
                for (int record = 0; record < allCompanyClients.Count; record++)
                {
                    string[] dataArray = allCompanyClients[record].Split('*');
                    string currentIDNumber = dataArray[3];
                    if (this.CompanyIDNumberInput.Text == currentIDNumber)
                    {
                        this.CompanyNameInput.Text = dataArray[1];
                        this.CompanyAddressInput.Text = dataArray[2];
                        this.CompanyPhoneInput.Text = dataArray[4];
                        break;
                    }
                }
            }

            catch (CourierManager.InvalidIDNumberException ide)
            {
                if (!isWindowClosing)
                {
                    this.CompanyIDNumberInput.Focusable = true;
                    Keyboard.Focus(this.CompanyIDNumberInput);
                    ErrorWindow newIDWindow = new ErrorWindow();
                    newIDWindow.ErrorText.Text = ide.Message;
                    newIDWindow.Show();
                }
            }
        }

        private void ProcessCompanyClient(object sender, RoutedEventArgs e)
        {
            
                //collapse the sender form and move on to the recepient form
            if (this.SenderGrid.Visibility == System.Windows.Visibility.Visible)
            {
                ulong phone = ulong.Parse(this.CompanyPhoneInput.Text);
                ulong idNumber = ulong.Parse(this.CompanyIDNumberInput.Text);
                senderCompany = new CourierManager.CompanyCustomer(this.CompanyNameInput.Text, this.CompanyAddressInput.Text,
                    idNumber, phone);
                this.CompanyRecipientGrid.Visibility = System.Windows.Visibility.Visible;
                this.RecipientType.Visibility = System.Windows.Visibility.Visible;
                this.RecipientTypeMenu.Visibility = System.Windows.Visibility.Visible;
                this.CompanyForm.Visibility = System.Windows.Visibility.Collapsed;
                this.SenderGrid.Visibility = System.Windows.Visibility.Collapsed; 
            }
                
            else if (SenderGrid.Visibility == System.Windows.Visibility.Collapsed
                && (CompanyRecipientGrid.Visibility == System.Windows.Visibility.Visible || 
                IndividualRecipientGrid.Visibility == System.Windows.Visibility.Visible))
            {
                this.IndividualRecipientGrid.Visibility = System.Windows.Visibility.Collapsed;
                this.CompanyRecipientGrid.Visibility = System.Windows.Visibility.Collapsed;
                this.RecipientType.Visibility = System.Windows.Visibility.Collapsed;
                this.RecipientTypeMenu.Visibility = System.Windows.Visibility.Collapsed;
                this.FreightGrid.Visibility = System.Windows.Visibility.Visible;
                this.SubmitCompanyData.Visibility = System.Windows.Visibility.Collapsed;

                if (this.RecipientMenuHeader.Header == IndividualRecipient.Header)
                {
                    ulong phone = ulong.Parse(this.IndividualRecipientPhoneInput.Text);
                    recepient = new CourierManager.IndividualCustomer(this.IndividualRecipientFirstNameInput.Text, this.IndividualRecipientLastNameInput.Text,
                        this.IndividualRecipientAddressInput.Text, 0, phone);
                }
                if (this.RecipientMenuHeader.Header == CompanyRecipient.Header)
                {
                    ulong phone = ulong.Parse(this.CompanyRecipientPhoneInput.Text);
                    recepient = new CourierManager.CompanyCustomer(this.CompanyRecipientNameInput.Text, this.CompanyRecipientAddressInput.Text, 0,
                        phone);
                }
            }
        }
        private void ProccessFreightData(object sender, RoutedEventArgs e)
        {
            //TODO: Make instance of Freight class

            //(Location)Enum.Parse(typeof(Location),this.comboboxLocation.SelectedValue) !!!
            //CourierManager.Location location = (CourierManager.Location)this.comboboxLocation.SelectedItem;
            //decimal weight = decimal.Parse(this.FreightWeightInput.Text);
            //CourierManager.Freight currentFreight = new CourierManager.Freight(weight, senderCompany, recepient, location);
        }
        private void ChangeRecipientType(object sender, RoutedEventArgs e)
        {
            IndividualRecipient.Click += (send, even) =>
            {
                
                this.RecipientMenuHeader.Header = IndividualRecipient.Header;
                //make company recepient fields collapse
                this.CompanyRecipientGrid.Visibility = System.Windows.Visibility.Collapsed;
                //make individual recepient fields visible
                this.IndividualRecipientGrid.Visibility = System.Windows.Visibility.Visible;

            };
            CompanyRecipient.Click += (send, even) =>
            {
                this.RecipientMenuHeader.Header = CompanyRecipient.Header;
                //make individual recepient fields collapse
                this.IndividualRecipientGrid.Visibility = System.Windows.Visibility.Collapsed;
                //make company fields visible
                this.CompanyRecipientGrid.Visibility = System.Windows.Visibility.Visible;
            };
        }
    }
}
