﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace sussybakka
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

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        

        private void SubmitButton_Click(object sender,RoutedEventArgs e)
        {
           



        }



        private void MinimiseButton_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
        private void ExpandButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            
            
        }

 

        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            
            Window1 window1 = new Window1();
            window1.Show();
            this.Close();
        }

        private void UserName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }


}
