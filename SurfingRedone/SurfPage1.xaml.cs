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

        SurfsUp db = new SurfsUp();
        public SurfPage1()
        {
            InitializeComponent();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var query = from b in db.Beaches
                        select b;

            lbxBeaches.ItemsSource = query.ToList();//filling up the beach listbox with beaches and their images

            var query2 = from sb in db.Boards//filling up the rentable boards with prices
                         select sb;

            lbxRentBoards.ItemsSource = query2.ToList();
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
        private void btnlength1_Click_1(object sender, RoutedEventArgs e)
        {
            ResetButtonColours();
            btnlength1.Background = new SolidColorBrush(Colors.Green);
            ResetLength();
            tbxLength.Text = btnlength1.Content.ToString();
        }

        private void btnlength2_Click_1(object sender, RoutedEventArgs e)
        {
            ResetButtonColours();
            btnlength2.Background = new SolidColorBrush(Colors.Green);
            ResetLength();
            tbxLength.Text = btnlength2.Content.ToString();
        }

        private void btnlength3_Click_1(object sender, RoutedEventArgs e)
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
        private void teacherRadioChange()//when teacher is clicked, then lesson information is updated
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

        private void lbxBeaches_SelectionChanged(object sender, SelectionChangedEventArgs e)//when a beach is clicked, it changes it on the lesson.
        {
            Beach selectedBeach = lbxBeaches.SelectedItem as Beach;

            tbxBeach.Text = selectedBeach.BName.ToString();
        }

        private void lbxRentBoards_SelectionChanged(object sender, SelectionChangedEventArgs e)//when board is clicked, it is updated on the lesson information
        {
            Board selectedBoard = lbxRentBoards.SelectedItem as Board;
            tbxBoard.Text = selectedBoard.BoardName.ToString();
        }

        public bool lessonValid()//checking that all of my lesson details have been entered
        {
            bool output = false;
            if (tbxTeacher.Text.Length > 1 
                && tbxLength.Text.Length > 1
                && tbxDate.Text.Length > 1
                && tbxBeach.Text.Length > 1
                && tbxBoard.Text.Length > 1)
            {
                return output = true;
            }
            return output;
        }
        private void btnBookLesson_Click(object sender, RoutedEventArgs e)//changed the button to green/red depending on whether the details are correct
        {
           

            if (lessonValid() == true)
            {
                Console.WriteLine("hello");
                btnBookLesson.Background = new SolidColorBrush(Colors.Green);
            }
            else
            {
                Console.WriteLine("not workingg");
                btnBookLesson.Background = new SolidColorBrush(Colors.Red);
            }
        }

        private void btnRentThisBoard_Click(object sender, RoutedEventArgs e)
        {
            Board selectedBoard = lbxRentBoards.SelectedItem as Board;
            tbxBoard.Text = selectedBoard.BoardName.ToString();
        }
    }
}

