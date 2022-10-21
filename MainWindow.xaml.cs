using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Timers;
namespace sussybakka
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static System.Timers.Timer aTimer;
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

        private void SignInButton_Click(object sender, RoutedEventArgs e)
        {

            //open connection to sql server
            //check if data already exists
            try
            {
                using (SqlConnection con = new SqlConnection(@"Server=DESKTOP-31579CJ\SQLEXPRESS;Database=LoginInformation;Trusted_connection = True;"))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT Username,Pass FROM [Users] WHERE Username = @UserName AND Pass = @Password", con))
                    {
                        SqlParameterCollection parameters1 = cmd.Parameters;
                        cmd.Parameters.AddWithValue("@UserName", Username.Text);
                        cmd.Parameters.AddWithValue("@Password", Password.Password);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                
                                Loading Loading1 = new Loading();
                                Loading1.Show();
                                this.Close();
                            }
                            else
                            {
                                
                                // MessageBox.Show("Incorrect username or password");
                                IUL.Visibility = Visibility.Visible;
                                Username.Text = "";
                                Password.Password = "";
                                
                            }
                        }
                    }
                    
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}





