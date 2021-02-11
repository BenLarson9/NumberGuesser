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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NumberGuesser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int number;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {

            if (babybutton.IsChecked == true)
            {
                Random randNum = new Random();
                number = randNum.Next(1, 11);
                //make all buttons disabled
            }
            else if (toddlerbutton.IsChecked == true)
            {
                Random randNum = new Random();
                number = randNum.Next(1, 101);
                //make all buttons disabled

            }
            else if (adultbutton.IsChecked == true)
            {
                Random randNum = new Random();
                number = randNum.Next(1, 10001);
                //make all buttons disabled

            }
            else
            {
                //need to make it repeat and not remove choices yet
            }

        }

        private void EnterButton_Click(object sender, RoutedEventArgs e)
        {

        }

       
    }
}
