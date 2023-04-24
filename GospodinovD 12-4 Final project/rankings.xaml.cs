using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GospodinovD_12_4_Final_project
{
    /// <summary>
    /// Interaction logic for rankings.xaml
    /// </summary>
    public partial class rankings : Window
    {
        public rankings()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            checkpage1 cp = new checkpage1();
            cp.Show();
            this.Close();

          
        }
    }
}

