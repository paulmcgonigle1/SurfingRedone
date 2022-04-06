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

namespace SurfingRedone
{
    /// <summary>
    /// Interaction logic for MainMenuPage.xaml
    /// </summary>
    public partial class MainMenuPage : Window
    {

        SurfsUp6 db = new SurfsUp6();
        User activeUser;
        public MainMenuPage()
        {
            InitializeComponent();
        }
        public MainMenuPage(User user)
        {
            InitializeComponent();

            activeUser = user;

            imgMyAccount.Source = new BitmapImage(new Uri(user.ProfilePic, UriKind.Relative));//setting active userImage as whatever

            signedName.Text = $"{user.FirstName} {user.Surname}";


                       


        }


        private void btnSurfPage_Click(object sender, RoutedEventArgs e)
        {
            SurfPage1 surfPage = new SurfPage1(activeUser);//will set the active user when it gets to this page

            surfPage.Show(); //making it modal

            this.Close();

        }

        private void btnMyAccount_Click(object sender, RoutedEventArgs e)
        {
            AccountPage accountPage = new AccountPage(activeUser);

            this.Close();
            accountPage.Show();

            
        }

        private void btnShop_Click(object sender, RoutedEventArgs e)
        {
            ShopPage shopPage = new ShopPage(activeUser);

            this.Close();
            shopPage.Show();    
        }
    }
}
