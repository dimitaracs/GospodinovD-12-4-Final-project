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
    /// Interaction logic for checkpage1.xaml
    /// </summary>
    public partial class checkpage1 : Window
    {
        public checkpage1()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string dbsCon = @"Data Source=LABSCIFIPC22\LOCALHOST;Initial Catalog=dgfinalproject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection sqlCon_ = new SqlConnection(dbsCon);


            try
            {
                MainWindow t = new MainWindow();
                t.Show();
                sqlCon_.Open();
                string query = "";
                SqlCommand cmd = new SqlCommand(query, sqlCon_);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                Seniors_WRL dt = new Seniors_WRL();
                adapter.Fill(dt);
                t.Seniors_WRL.ItemsSource = dt.DefaultView;
                adapter.Update(dt);
                this.Close();
                sqlCon_.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
