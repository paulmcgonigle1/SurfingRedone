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
        SurfsUp13 db = new SurfsUp13();


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
                            select user;

                var loggedUser = query.First();//getting the user that was entered into the login

                string pass = loggedUser.Password;

                
                if (user_password.Equals(pass))
                {

                    MainMenuPage mainMenu = new MainMenuPage(loggedUser);//when going to main menu, the active user will be the one that was entered

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
