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
        public MainMenuPage()
        {
            InitializeComponent();
        }
        

        private void btnSurfPage_Click(object sender, RoutedEventArgs e)
        {
            SurfPage1 surfPage = new SurfPage1();

            surfPage.Show(); //making it modal

            this.Close();

        }

        private void btnMyAccount_Click(object sender, RoutedEventArgs e)
        {
            AccountPage accountPage = new AccountPage();

            this.Close();
            accountPage.Show();

            
        }
    }
}
