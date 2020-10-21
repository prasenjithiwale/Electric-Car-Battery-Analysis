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

namespace Battery_Management
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

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            msgBox.Content = "Cell 1: " + Math.Round(slider00.Value, 2) + "\tCell 2: " + Math.Round(slider01.Value,2) + "\tCell 3: " + Math.Round(slider02.Value,2) + "\tCell 4: " + Math.Round(slider03.Value,2);
        }
    }
}
