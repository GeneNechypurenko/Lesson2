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

namespace Task2
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

        private void applyButton_Click(object sender, RoutedEventArgs e)
        {
            if (redRadioButton.IsChecked == true)
                this.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("Red"));

            if (blueRadioButton.IsChecked == true)
                this.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("Blue"));

            if (greenRadioButton.IsChecked == true)
                this.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("Green"));
        }
    }
}
