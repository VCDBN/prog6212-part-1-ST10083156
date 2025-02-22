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

namespace PROG6212_POE
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Initializer for page
        public MainWindow()
        {
            InitializeComponent();
        }
        //Welcome button, transfers user to first page of application
        private void welcomeBtn_Click(object sender, RoutedEventArgs e)
        {
            ModuleWindow moduleWindow = new ModuleWindow();
            this.Hide();
            moduleWindow.Show();
            this.Close();
        }
    }
}
