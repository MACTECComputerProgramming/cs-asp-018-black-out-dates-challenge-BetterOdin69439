using System;
using System.Windows;
using System.Windows.Controls;

namespace ASP18
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //Instantiate two Date Time variables

        public DateTime x, y; 

        // Get First Date

        private void myCalendar1_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {

            x = myCalendar1.SelectedDate.Value;

            labelAnswer1.Content = x;
        
        
        
        
        
        
        
        
        
        }

        private void myCalendar2_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {

            y = myCalendar2.SelectedDate.Value;

            labelAnswer2.Content = y;


        }


        private void button_Click(object sender, RoutedEventArgs e)
        {

            myCalader3.BlackoutDates.Add(new System.Windows.Controls.CalendarDateRange(x, y));

            resultLabel.Content = (y.Date - x.Date).Days;


        }

      




    }
}
