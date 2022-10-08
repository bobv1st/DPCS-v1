using System;
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
using System.Windows.Shapes;

namespace sussybakka
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

     

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainw = new MainWindow();
            mainw.Show();
            this.Close();
        }

        private void MinimiseButton_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            //open connection to sql server


            try
            {


                //insert data into database
                //check if data already exists

                using (SqlConnection con = new SqlConnection(@"Server=DESKTOP-31579CJ\SQLEXPRESS;Database=LoginInformation;Trusted_connection = True;"))
                { 

                    SqlCommand cmd = new SqlCommand(@"SELECT Username FROM [User] WHERE Username = '" + Username.Text + "'", con);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        MessageBox.Show("Username already exists");
                    }
                    else
                    {
                        dr.Close();
                        MessageBox.Show("Account created");
                        cmd = new SqlCommand(@"INSERT INTO [User] (Username,Password,UserID) VALUES (@Username,@Password,@UserID)", con);
                        cmd.ExecuteNonQuery();
                        

                    //clear textboxes
                        Username.Text = "";
                        Password.Password = "";
                    }
                    dr.Close();
                    con.Close();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception occured" + ": " + ex.Message);
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-31579CJ\SQLEXPRESS;Initial Catalog=LoginInformation;Integrated Security=True;User ID = yes; Password = yes");
                //create table if one does not exist
                SqlCommand cmd = new SqlCommand("CREATE TABLE User (Username varchar(50), Password varchar(50))", con);
                
           


            }





        }

        
           
        
    }
}

// Language: csharp