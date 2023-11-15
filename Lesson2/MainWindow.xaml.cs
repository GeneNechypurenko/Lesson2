using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Lesson2
{

    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

            string[] color = new string[]
            {
        "Navy",
        "Blue",
        "Aqua",
        "Teal",
        "Olive",
        "Green",
        "Lime",
        "Yellow",
        "Orange",
        "Red"
            };

            int i = 0;

            foreach (Button button in wrapButtonsPanel.Children)
            {
                if (i < color.Length)
                {
                    button.Content = color[i];
                    button.Background = (Brush)new BrushConverter().ConvertFromString(color[i]);
                    i++;
                }
            }
        }
    }
}