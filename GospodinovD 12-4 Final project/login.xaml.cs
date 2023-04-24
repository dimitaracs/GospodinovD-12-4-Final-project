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
 
    public partial class login : Window
    {
        public login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            //string username = this.username2.Text;
            // string password = this.password3.Password;

            SqlConnection sqlCon2 = new SqlConnection(@"Data Source=DESKTOP-EH77223; Initial Catalog = Project; Integrated Security = True");

            try
            {
                if (sqlCon2.State == ConnectionState.Closed)

                    sqlCon2.Open();


                string query = "SELECT COUNT(1) FROM SignUp where Username=@username and Password=@Password";


                SqlCommand cmd = new SqlCommand(query, sqlCon2);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Username", this.username2.Text);
                cmd.Parameters.AddWithValue("@Password", this.password3.Password);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count == 1)
                {
                    //CheckPage r = new CheckPage();
                   // r.Welcome.Content = $"Welcome, {username2.Text}";
                   // r.Show();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("The username or the password are not correct");
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            finally
            {

                sqlCon2.Close();

            }
        }
    }
}
