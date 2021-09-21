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

namespace CircleAnimator
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ArrangeButtons();

        }

        private async void ArrangeButtons()
        {
            await Task.Delay(1000);
            initialCircle.Margin = new Thickness(50, MainWind.Height / 4, 35, 0);
            initialCircle.Width = 80;
            initialCircle.Height = 100;
            initialCircle.Content = "Run";

            await Task.Delay(2000);
            initialCircle.Margin = new Thickness(50, MainWind.Height / 2, 35, 0);
            initialCircle.Width = 100;
            initialCircle.Height = 120;
            initialCircle.Content = "Expand";
            await Task.Delay(2000);

            initialCircle.Visibility = Visibility.Hidden;
            initialSquare.Visibility = Visibility.Visible;
            initialSquare.Margin = new Thickness(30, MainWind.Height-150 , 25, 0);
            initialSquare.Width = 150;
            initialSquare.Height = 150;
            initialSquare.Content = "End";
        }
    }
}
