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
    /// Interaction logic for AccountPage.xaml
    /// </summary>
    public partial class AccountPage : Window
    {
        User activeUser;
        SurfsUp6 db = new SurfsUp6();
        public AccountPage()
        {
            InitializeComponent();
        }
        public AccountPage(User user)
        {
            InitializeComponent();

            activeUser = user;

            imgMyAccount.Source = new BitmapImage(new Uri(user.ProfilePic, UriKind.Relative));//setting active userImage as whatever

            signedName.Text = $"{user.FirstName} {user.Surname}";





        }

        
        

        public static void getWallet()//method that will get the users wallet and ammount inside of it
        {
           //var query = from d in  db
        }

        private void AccountPage1_Loaded_1(object sender, RoutedEventArgs e)
        {
            var query3 = from us in db.Users
                         where us.UserName == activeUser.UserName
                         select us.Boards;
            lbxMyBoards.ItemsSource = query3.ToList();
        }

        private void lbxMyBoards_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //get it so that it gets that certain board from the database and then displays in the stackpanel the details of that certain board.
            Board selectedBoard = lbxMyBoards.SelectedItem as Board;
            var query = from sb in db.Boards
                        where sb.BoardID.Equals(selectedBoard.BoardID)
                        select sb.Type;

            tbxBoardType.Text = query.ToString();

        }

        private void btnShop_Click(object sender, RoutedEventArgs e)
        {
            MainMenuPage mainMenu = new MainMenuPage(activeUser);//when going to main menu, the active user will be the one that was entered

            mainMenu.Show(); //making it modal

            this.Close();
        }
    }
}
