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
using System.Windows.Shapes;

namespace SurfingRedone
{
    /// <summary>
    /// Interaction logic for AccountPage.xaml
    /// </summary>
    public partial class AccountPage : Window
    {
        public AccountPage()
        {
            InitializeComponent();
        }

        SurfsUp db = new SurfsUp();
        private void AccountPage1_Loaded(object sender, RoutedEventArgs e)
        {
            getWallet();
        }

        public static void getWallet()//method that will get the users wallet and ammount inside of it
        {
           //var query = from d in  db
        }
    }
}