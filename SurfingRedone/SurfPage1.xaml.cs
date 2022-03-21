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
    /// Interaction logic for SurfPage1.xaml
    /// </summary>
    public partial class SurfPage1 : Window
    {
        //SurfData db = new SurfData();//constructing surf data db
        public SurfPage1()
        {
            InitializeComponent();
        }

        private void SurfPageWindow_Loaded(object sender, RoutedEventArgs e)
        {
            //var query = from b in db.Beaches//this query gets the beach from the database
            //            select b;

            //lbxBeaches.ItemsSource = query.ToList();//filling up the beach listbox with beaches and their images


        }

        //this is a refresh method that refreshes everything in the BOOKING DETAILS to make sure everything is up to date
        private void Refresh()
        {

            tbxDate.Text = calendarLesson.SelectedDate.ToString();
        }



        private void calendarLesson_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            Refresh();
        }

        //these 3 will change the colour of the clicked button and add detail to booking
        private void btnlength1_Click(object sender, RoutedEventArgs e)
        {
            ResetButtonColours();
            btnlength1.Background = new SolidColorBrush(Colors.Green);
            ResetLength();
            tbxLength.Text = btnlength1.Content.ToString();
        }
        private void btnlength2_Click(object sender, RoutedEventArgs e)
        {
            ResetButtonColours();
            btnlength2.Background = new SolidColorBrush(Colors.Green);
            ResetLength();
            tbxLength.Text = btnlength2.Content.ToString();
        }

        private void btnlength3_Click(object sender, RoutedEventArgs e)
        {
            ResetButtonColours();
            btnlength3.Background = new SolidColorBrush(Colors.Green);
            ResetLength();
            tbxLength.Text = btnlength3.Content.ToString();
        }

        //method that resets all buttons colours on a new click
        private void ResetButtonColours()
        {
            btnlength1.Background = new SolidColorBrush(Colors.Wheat);
            btnlength2.Background = new SolidColorBrush(Colors.Wheat);
            btnlength3.Background = new SolidColorBrush(Colors.Wheat);

        }
        private void ResetLength()
        {
            tbxLength.Text = string.Empty;
        }

        private void rbTeacher1_Checked(object sender, RoutedEventArgs e)
        {
            teacherRadioChange();
        }
        private void rbTeacher2_Checked(object sender, RoutedEventArgs e)
        {
            teacherRadioChange();
        }
        private void rbTeacher3_Checked(object sender, RoutedEventArgs e)
        {
            teacherRadioChange();
        }
        private void teacherRadioChange()
        {
            tbxTeacher.Text = String.Empty;

            if (rbTeacher1.IsChecked == true)
            {
                tbxTeacher.Text = lblTeacher1.Content.ToString();
            }
            else if (rbTeacher2.IsChecked == true)
            {
                tbxTeacher.Text = lblTeacher2.Content.ToString();
            }
            else if (rbTeacher3.IsChecked == true)
            {
                tbxTeacher.Text = lblTeacher3.Content.ToString();
            }


        }

        private void lbxBeaches_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Beach selectedBeach = lbxBeaches.SelectedItem as Beach;

            //tbxBeach.Text = selectedBeach.BName.ToString();
        }
    }
}

