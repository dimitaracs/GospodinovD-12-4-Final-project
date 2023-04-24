using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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
            string dbsCon = @"Data Source = LABSCIFIPC22\LOCALHOST; Initial Catalog = dgfinalpr; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            SqlConnection sqlCon_ = new SqlConnection(dbsCon);


            try
            {
                rankings rk = new rankings();
                sqlCon_.Open();
                string query = "Select * from Seniors_WRL";
                SqlCommand cmd = new SqlCommand(query, sqlCon_);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                rk.table.ItemsSource = dt.DefaultView;
                adapter.Update(dt);
                rk.Show();
                this.Close();
               // MessageBox.Show("Successful loading");
                sqlCon_.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void jnrs(object sender, RoutedEventArgs e)
        {
            string dbsCon = @"Data Source=LABSCIFIPC22\LOCALHOST;Initial Catalog=dgfinalpr;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection sqlCon_ = new SqlConnection(dbsCon);


            try
            {
                rankings rk = new rankings();
                sqlCon_.Open();
                string query = "Select * from juniors_wrl";
                SqlCommand cmd = new SqlCommand(query, sqlCon_);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                rk.table.ItemsSource = dt.DefaultView;
                adapter.Update(dt);
                rk.Show();
                this.Close();
                // MessageBox.Show("Successful loading");
                sqlCon_.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void kids_Click(object sender, RoutedEventArgs e)
        {
            string dbsCon = @"Data Source=LABSCIFIPC22\LOCALHOST;Initial Catalog=dgfinalpr;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection sqlCon_ = new SqlConnection(dbsCon);


            try
            {
                rankings rk = new rankings();
                sqlCon_.Open();
                string query = "Select * from kids_wrl";
                SqlCommand cmd = new SqlCommand(query, sqlCon_);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                rk.table.ItemsSource = dt.DefaultView;
                adapter.Update(dt);
                rk.Show();
                this.Close();
                // MessageBox.Show("Successful loading");
                sqlCon_.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string dbsCon = @"Data Source=LABSCIFIPC22\LOCALHOST;Initial Catalog=dgfinalpr;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection sqlCon_ = new SqlConnection(dbsCon);

            int id1 = int.Parse(this.id.Text);

            try
            {
                if (id1>1 && id1 < 10000)
                {
                    rankings rk = new rankings();
                    rk.Show();
                    sqlCon_.Open();
                    string query = $"Select * from Seniors_WRL where ID = {this.id.Text}";
                    SqlCommand cmd = new SqlCommand(query, sqlCon_);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    rk.table.ItemsSource = dt.DefaultView;
                    adapter.Update(dt);
                    this.Close();
                    sqlCon_.Close();
                }
                else
                {
                    MessageBox.Show("A judoka with such an ID does not exist");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void NandW_Click(object sender, RoutedEventArgs e)
        {
            string dbsCon = @"Data Source=LABSCIFIPC22\LOCALHOST;Initial Catalog=dgfinalpr;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection sqlCon_ = new SqlConnection(dbsCon);


            try
            {
                rankings rk = new rankings();
                sqlCon_.Open();
                string query = "Select * from nations_wrl";
                SqlCommand cmd = new SqlCommand(query, sqlCon_);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                rk.table.ItemsSource = dt.DefaultView;
                adapter.Update(dt);
                rk.Show();
                this.Close();
                // MessageBox.Show("Successful loading");
                sqlCon_.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string dbsCon = @"Data Source=LABSCIFIPC22\LOCALHOST;Initial Catalog=dgfinalpr;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection sqlCon_ = new SqlConnection(dbsCon);

           

            try
            {
                if (Convert.ToInt32(id.Text) > 1 && Convert.ToInt32(id.Text) < 100)
                {
                    rankings rk = new rankings();
                    rk.Show();
                    sqlCon_.Open();
                    string query = $"Select * from nations_wrl where ID = {Convert.ToInt32(this.id.Text)}";
                    SqlCommand cmd = new SqlCommand(query, sqlCon_);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    rk.table.ItemsSource = dt.DefaultView;
                    adapter.Update(dt);
                    this.Close();
                    sqlCon_.Close();
                }
                else
                {
                    MessageBox.Show("A nation with such an ID does not exist");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


    }
}
