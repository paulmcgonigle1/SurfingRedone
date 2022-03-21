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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }
        MyNewSurfData db = new MyNewSurfData();


        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            string enteredUserName = tbxUserName.Text;
            //if (enteredUserName.Equals()
            //{

            //}

            MainMenuPage mainMenu = new MainMenuPage();

            mainMenu.Show(); //making it modal

            this.Close();

        }

        private void txtUserEnter(object sender, EventArgs e)
        {
            if (tbxUserName.Text.Equals(' '))//making sure that the textbox displays a hint to write in stuff if nothing is entered
            {
                tbxUserName.Text = "Enter Valid Username";
            }
        }

        private void txtPassEnter (object sender, EventArgs e)
        {
            if (tbxUserName.Text.Equals(' '))//making sure that the textbox displays a hint to write in stuff if nothing is entered
            {
                tbxUserName.Text = "Enter Valid Username";
            }
        }
    }
}
