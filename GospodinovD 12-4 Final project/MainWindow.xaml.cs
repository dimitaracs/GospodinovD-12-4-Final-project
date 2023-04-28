using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace GospodinovD_12_4_Final_project
{
  
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=LABSCIFIPC22\LOCALHOST;Initial Catalog=dgfinalpr;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            //
            if (password.Password != password2.Password)
            {
                MessageBox.Show("Different inputs of the password");
                this.Close();
            }
            else
            {
                try
                {
                    if (sqlCon.State == ConnectionState.Closed)
                    {
                        sqlCon.Open();


                        string query = "INSERT INTO Signup1 (Username, Password1, Repeatpassword1) values ('" + this.username.Text + "','" + this.password.Password + "','" + this.password2.Password + "')";


                        SqlCommand cmd = new SqlCommand(query, sqlCon);
                        cmd.ExecuteNonQuery();


                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


                finally
                {
                    sqlCon.Close();


                    login g = new login();
                    g.Show();
                    this.Close();
                }
            }
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            login g = new login();
            g.Show();
            this.Close();
        }
    }
}
