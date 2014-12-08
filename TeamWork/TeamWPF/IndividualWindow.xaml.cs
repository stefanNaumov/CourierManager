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
    /// Interaction logic for IndividualWindow.xaml
    /// </summary>
    public partial class IndividualWindow : Window
    {
        public IndividualWindow()
        {
            InitializeComponent();
        }
        
        private CourierManager.IndividualCustomer senderClient;
        private CourierManager.Customer recepient;

        private void IndividualIDNumberLostFocus(object sender, RoutedEventArgs e)
        {
            
            try
            {
                CourierManager.ValidatorIDNumber.ValidatePersonalIDNumber(this.IndividualIDNumberInput.Text);
                CourierManager.IndividualCustomer tempCustomer =
                new CourierManager.IndividualCustomer("", "", "",ulong.Parse( this.IndividualIDNumberInput.Text), 1, false);
                tempCustomer.PathToDatabase = "../../../CourierManager/IndividualCustomers.txt";
                List<string> allIndividualClients = tempCustomer.ReadClientData();
                for (int record = 0; record < allIndividualClients.Count; record++)
                {
                    string[] dataArray = allIndividualClients[record].Split('*');
                    string currentIDNumber = dataArray[4];
                    if (this.IndividualIDNumberInput.Text == currentIDNumber)
                    {
                        this.IndividualNameInput.Text = dataArray[1];
                        this.IndividualLastNameInput.Text = dataArray[2];
                        this.IndividualAddressInput.Text = dataArray[3];
                        this.IndividualPhoneInput.Text = dataArray[5];
                        break;
                    }
                }
            }

            catch (CourierManager.InvalidIDNumberException ide)
            {
                this.IndividualIDNumberInput.Focusable = true;
                Keyboard.Focus(this.IndividualIDNumberInput);
                //InvalidIDNumber newIDWindow = new InvalidIDNumber();
                //newIDWindow.ErrorText.Text=ide.Message;
                //newIDWindow.Show();
            }
        }

        private void ProccessIndividualClient(object sender, RoutedEventArgs e)
        {
            if (this.SenderGrid.Visibility == System.Windows.Visibility.Visible)
            {
                ulong phone = ulong.Parse(this.IndividualPhoneInput.Text);
                ulong idNumber = ulong.Parse(this.IndividualIDNumberInput.Text);
                senderClient = new CourierManager.IndividualCustomer(this.IndividualNameInput.Text, this.IndividualLastNameInput.Text,
                    this.IndividualAddressInput.Text, idNumber, phone);
                //making the window form change from sender to recipient
                //making the sender fields collapsed
                this.SenderType.Visibility = System.Windows.Visibility.Collapsed;
                this.IndividualForm.Visibility = System.Windows.Visibility.Collapsed;
                this.SenderGrid.Visibility = System.Windows.Visibility.Collapsed;
                //making the recipient fields visible
                this.RecipientType.Visibility = System.Windows.Visibility.Visible;
                this.RecipientTypeMenu.Visibility = System.Windows.Visibility.Visible;
                this.CompanyRecepientGrid.Visibility = System.Windows.Visibility.Visible;
            }
            
            else if (this.SenderGrid.Visibility == System.Windows.Visibility.Collapsed 
                && ( this.IndividualRecepientGrid.Visibility == System.Windows.Visibility.Visible 
                || this.CompanyRecepientGrid.Visibility == System.Windows.Visibility.Visible ))
                
            {
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
                this.RecipientType.Visibility = System.Windows.Visibility.Collapsed;
                this.SubmitIndividualData.Visibility = System.Windows.Visibility.Collapsed;
                this.IndividualRecepientGrid.Visibility = System.Windows.Visibility.Collapsed;
                this.CompanyRecepientGrid.Visibility = System.Windows.Visibility.Collapsed;
                this.FreightGrid.Visibility = System.Windows.Visibility.Visible;
            }
            
        }

        private void ChangeRecipientType(object sender, RoutedEventArgs e)
        {
            IndividualRecipient.Click += (send, even) =>
                {
                    this.RecipientMenuHeader.Header = IndividualRecipient.Header;
                    //make company recepient fields collapse
                    this.CompanyRecepientGrid.Visibility = System.Windows.Visibility.Collapsed;
                    //make individual recepient fields visible
                    this.IndividualRecepientGrid.Visibility = System.Windows.Visibility.Visible;
                };
            CompanyRecipient.Click += (send, even) =>
                {
                    this.RecipientMenuHeader.Header = CompanyRecipient.Header;
                    //make individual recepient fields collapse
                    this.IndividualRecepientGrid.Visibility = System.Windows.Visibility.Collapsed;
                    //make company fields visible
                    this.CompanyRecepientGrid.Visibility = System.Windows.Visibility.Visible;
                };
        }
        private void ProccessFreightData(object sender, RoutedEventArgs e)
        {
            //TODO: Make instance of Freight class

            //CourierManager.Location location = (CourierManager.Location)this.comboboxLocation.SelectedItem;
        }
    }
}
