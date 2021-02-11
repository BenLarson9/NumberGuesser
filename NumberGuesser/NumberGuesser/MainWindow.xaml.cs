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
        public MainWindow()
        {
            InitializeComponent();
        }
        Player player = new Player();
        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            player3.IsChecked = false;
            while ((bool)!player3.IsChecked&& (bool)!player2.IsChecked && (bool)!player1.IsChecked)
            {
                rlb.Content = "No one is playing!";
            }
            if ((bool)player1.IsChecked) player.SetPlayer(1);
            if ((bool)player2.IsChecked) player.SetPlayer(2);
            if ((bool)player3.IsChecked) player.SetPlayer(3);
        }

        private void EnterButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void babybutton_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
