using System;
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
using System.Data.SqlClient;

namespace SurfingRedone
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }
        SurfsUp db = new SurfsUp();

        
        public bool CanLogIn(string userName)//making sure that the user has entered details(NEED TO UPDATE THIS WITH DATABASE)
        {
            bool output = false;

            if (userName.Length > 0)
            {
                output = true;

            }
            return output;
        }

        public void LogIn(string userName)//LOGGIN USER METHOD
        {
            if (CanLogIn(userName) == true)
            {
                MainMenuPage mainMenu = new MainMenuPage();

                mainMenu.Show(); 

                this.Close();
            }
        }
        private void btnSubmit_Click2(object sender, RoutedEventArgs e)//TEMPORARY ON CLICK METHOD
        {
            string _username = tbxUserName.Text;

            CanLogIn(_username);

            LogIn(_username);



        }



        private void btnSubmit_Click(object sender, RoutedEventArgs e)//WANT THIS TO WORK
        {
            string username, user_password;

            username = tbxUserName.Text;
            user_password = tbxPassword.Text;

            try
            {
                 var query = from user in db.Users
                             where user.UserName == username
                             select user.UserName;
                //string query = "select * from dbo.Users where username = '" + tbxUserName.Text.Trim() + "' and password = '" + tbxPassword.Text.Trim() + "'";
                if (username.Equals(query.ToString()))
                {

                    MainMenuPage mainMenu = new MainMenuPage();

                    mainMenu.Show(); //making it modal

                    this.Close();
                }
                else
                {
                    Console.WriteLine("Wrong Username or an error in code");
                }

                
            }
            catch (Exception)
            {

                throw;
            }

           


        }

       

       
    }
}
