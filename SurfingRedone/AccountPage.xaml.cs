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
        public AccountPage()
        {
            InitializeComponent();
        }

        SurfsUp3 db = new SurfsUp3();
        

        public static void getWallet()//method that will get the users wallet and ammount inside of it
        {
           //var query = from d in  db
        }

        private void AccountPage1_Loaded_1(object sender, RoutedEventArgs e)
        {
            var query2 = from sb in db.Boards//filling up the rentable boards with prices
                         select sb;

            lbxMyBoards.ItemsSource = query2.ToList();
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
    }
}
