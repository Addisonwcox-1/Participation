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

namespace WPF1
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

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            Application EntryForm = new Application();

            EntryForm.name = txtName.Text;
            EntryForm.address = txtAddress.Text;
            EntryForm.zipCode = Convert.ToInt32(txtZip);
            Console.Write($"Your name is {Name} and your address and zip is {Address} {Zip}");
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            

            


        

        }
    }
}
