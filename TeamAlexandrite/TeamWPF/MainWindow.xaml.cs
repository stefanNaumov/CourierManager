﻿using System;
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

namespace TeamWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Logging loggingWindow = new Logging();
            loggingWindow.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.LayoutRoot.Children.Clear();
            FirstMenu.Visibility = Visibility.Visible;
            FirstMenu.Margin = new Thickness(-200, 0, 0, 0);
            FirstMenu.RowDefinitions.Add(new RowDefinition());
            FirstMenu.RowDefinitions.Add(new RowDefinition());
            IndividualCustomer.Checked += (send, ev) => { CompanyCustomer.IsChecked = false; };
            CompanyCustomer.Checked += (send, ev) => { IndividualCustomer.IsChecked = false; };
            Grid.SetColumn(IndividualCustomer, 1);
            Grid.SetRow(CompanyCustomer, 1);
            Grid.SetColumn(CompanyCustomer, 1);
            Next.Visibility = Visibility.Visible;
            this.LayoutRoot.Children.Add(Title);
            this.LayoutRoot.Children.Add(FirstMenu);
            this.LayoutRoot.Children.Add(Next);
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            if (this.CompanyCustomer.IsChecked == true)
            {
                CompanyWindow companyWindow = new CompanyWindow();
                companyWindow.Show();
            }

            else if (this.IndividualCustomer.IsChecked == true)
            {
                IndividualWindow individualWindow = new IndividualWindow();
                individualWindow.Show();
            }
        }

        private void Reports_Click(object sender, RoutedEventArgs e)
        {
            ReportsWindow reportWindow = new ReportsWindow();
            reportWindow.Show();
        }


        private void Register_Click(object sender, RoutedEventArgs e)
        {
            this.LayoutRoot.Children.Clear();
            SelectMenu.Visibility = Visibility.Visible;
            SelectMenu.Margin = new Thickness(-200, 0, 0, 0);
            SelectMenu.RowDefinitions.Add(new RowDefinition());
            SelectMenu.RowDefinitions.Add(new RowDefinition());
            RegisterNewEmployeee.Checked += (send, ev) => { RegisterNewVehicle.IsChecked = false; };
            RegisterNewVehicle.Checked += (send, ev) => { RegisterNewEmployeee.IsChecked = false; };
            Grid.SetColumn(RegisterNewEmployeee, 1);
            Grid.SetRow(RegisterNewVehicle, 1);
            Grid.SetColumn(RegisterNewVehicle, 1);
            Continue.Visibility = Visibility.Visible;
            this.LayoutRoot.Children.Add(Title);
            this.LayoutRoot.Children.Add(SelectMenu);
            this.LayoutRoot.Children.Add(Continue);
        }

        private void Continue_Click(object sender, RoutedEventArgs e)
        {
            if (this.RegisterNewEmployeee.IsChecked == true)
            {
                EmployeeWindow employeeWindow = new EmployeeWindow();
                employeeWindow.Show();
            }

            else if (this.RegisterNewVehicle.IsChecked == true)
            {
                VehicleWindow vehicleWindow = new VehicleWindow();
                vehicleWindow.Show();
            }
        }
    }

}
