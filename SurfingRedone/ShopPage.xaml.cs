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
    /// Interaction logic for ShopPage.xaml
    /// </summary>
    public partial class ShopPage : Window
    {
        SurfsUp12 db = new SurfsUp12();
        User activeUser;
        public ShopPage()
        {
            InitializeComponent();
        }
        public ShopPage(User user)
        {
            InitializeComponent();

            activeUser = user;

            imgMyAccount.Source = new BitmapImage(new Uri(user.ProfilePic, UriKind.Relative));//setting active userImage as whatever

            signedName.Text = $"{user.FirstName} {user.Surname}";

            tbxBalance.Text = user.Balance.ToString();



        }

        private void shopWindow_Loaded(object sender, RoutedEventArgs e)
        {
            var query1 = from b in db.Boards//filling mini boards
                         where b.Type == "Mini"
                         select b;
            lbxMiniBoards.ItemsSource = query1.ToList();

            var query2 = from b in db.Boards//filling mini boards
                         where b.Type == "Short"
                         select b;
            lbxShortBoards.ItemsSource = query2.ToList();

            var query3 = from b in db.Boards//filling mini boards
                         where b.Type == "Long"
                         select b;
            lbxLongBoards.ItemsSource = query3.ToList();

        }

        private void btnBuyBoard_Click(object sender, RoutedEventArgs e)
        {
            //selected board
            if (tabLongBoards.IsSelected)
            {
                Board sel = lbxLongBoards.SelectedItem as Board;
                var query1 = from sb in db.Boards
                             where sb.BoardID == sel.BoardID
                             select sb;
                if (sel != null)
                {
                    if (activeUser.Balance > sel.Price)
                    {
                        foreach (Board ord in query1)
                        {
                            ord.UserID = activeUser.UserID;


                        }


                        MessageBox.Show("Long Board Purchased");

                        activeUser.Balance = activeUser.Balance -= sel.Price;

                        tbxBalance.Text = activeUser.Balance.ToString();

                        db.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("Not Enough Funds to buy this board");
                    }

                }
                else
                {
                    MessageBox.Show("No selected Board");
                }

            }

            else if (tabMiniBoards.IsSelected)
            {

                Board sel = lbxMiniBoards.SelectedItem as Board;
                var query1 = from sb in db.Boards
                             where sb.BoardID == sel.BoardID
                             select sb;

                if (sel != null)
                {
                    if (activeUser.Balance > sel.Price)
                    {
                        foreach (Board ord in query1)
                        {
                            ord.UserID = activeUser.UserID;


                        }


                        MessageBox.Show("Mini Board Purchased");

                        activeUser.Balance = activeUser.Balance -= sel.Price;

                        tbxBalance.Text = activeUser.Balance.ToString();

                        db.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("Not Enough Funds to buy this board");
                    }
                }
                else
                {
                    MessageBox.Show("No selected Board");
                }

            }
            else if (tabShortBoards.IsSelected)
            {
                Board sel = lbxShortBoards.SelectedItem as Board;
                var query1 = from sb in db.Boards
                             where sb.BoardID == sel.BoardID
                             select sb;
                if (sel != null)
                {
                    if (activeUser.Balance > sel.Price)
                    {
                        foreach (Board ord in query1)
                        {
                            ord.UserID = activeUser.UserID;


                        }


                        MessageBox.Show("Short Board Purchased");

                        activeUser.Balance = activeUser.Balance -= sel.Price;

                        tbxBalance.Text = activeUser.Balance.ToString();

                        db.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("Not Enough Funds to buy this board");
                    }
                }
                else
                {
                    MessageBox.Show("No selected Board");
                }
            }

            //check for null

            //add to user list of boards
        }

        private void btnShop_Click(object sender, RoutedEventArgs e)
        {
            MainMenuPage mainMenu = new MainMenuPage(activeUser);//when going to main menu, the active user will be the one that was entered

            mainMenu.Show(); //making it modal

            this.Close();
        }

        //private void btnBuyBoard_Click_1(object sender, RoutedEventArgs e)//button that checks which board is collected and then allows user to buy board if there is enough in wallet
        //{
        //    if (tabLongBoards.IsSelected)
        //    {
        //        Board sel = lbxLongBoards.SelectedItem as Board;
        //        var query1 = from sb in db.Boards
        //                     where sb.BoardID == sel.BoardID
        //                     select sb;
        //        if (sel != null )
        //        {
        //            if (activeUser.Balance > sel.Price)
        //            {
        //                foreach (Board ord in query1)
        //                {
        //                    ord.UserID = activeUser.UserID;


        //                }


        //                MessageBox.Show("Long Board Purchased");

        //                activeUser.Balance = activeUser.Balance -= sel.Price;

        //                tbxBalance.Text = activeUser.Balance.ToString();

        //                db.SaveChanges();
        //            }
        //            else
        //            {
        //                MessageBox.Show("Not Enough Funds to buy this board");
        //            }
                    
        //        }
                
        //    }
           
        //    else if (tabMiniBoards.IsSelected)
        //    {

        //        Board sel = lbxMiniBoards.SelectedItem as Board;
        //        var query1 = from sb in db.Boards
        //                 where sb.BoardID == sel.BoardID
        //                 select sb;

        //        if (sel!= null)
        //        {
        //            if (activeUser.Balance > sel.Price)
        //            {
        //                foreach (Board ord in query1)
        //                {
        //                    ord.UserID = activeUser.UserID;


        //                }


        //                MessageBox.Show("Mini Board Purchased");
                        
        //                db.SaveChanges();
        //            }
        //            else
        //            {
        //                MessageBox.Show("Not Enough Funds to buy this board");
        //            }
        //        }
                
        //    }
        //    else if (tabShortBoards.IsSelected)
        //    {
        //        Board sel = lbxShortBoards.SelectedItem as Board;
        //        var query1 = from sb in db.Boards
        //                     where sb.BoardID == sel.BoardID
        //                     select sb;
        //        if (sel != null)
        //        {
        //            if (activeUser.Balance > sel.Price)
        //            {
        //                foreach (Board ord in query1)
        //                {
        //                    ord.UserID = activeUser.UserID;


        //                }


        //                MessageBox.Show("Mini Board Purchased");
        //                db.SaveChanges();
        //            }
        //            else
        //            {
        //                MessageBox.Show("Not Enough Funds to buy this board");
        //            }
        //        }
                
        //    }
        //}

        private void btnDeposit_Click(object sender, RoutedEventArgs e)
        {
            activeUser.Balance = activeUser.Balance += 100;
            tbxBalance.Text = activeUser.Balance.ToString();

            db.SaveChanges();

        }
    }
}
