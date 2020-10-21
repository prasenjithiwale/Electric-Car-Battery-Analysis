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

using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.Defaults;

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
            chart.Series = new SeriesCollection{
                new LineSeries
                {
                    Values = new ChartValues<double> { Math.Round(slider00.Value, 2), Math.Round(slider01.Value, 2), Math.Round(slider02.Value, 2), Math.Round(slider03.Value, 2) },
                    Stroke = System.Windows.Media.Brushes.Red
                },
                new ColumnSeries
                {
                    Values = new ChartValues<double> { Math.Round(slider00.Value, 2), Math.Round(slider01.Value, 2), Math.Round(slider02.Value, 2), Math.Round(slider03.Value, 2) },
                    Stroke = System.Windows.Media.Brushes.Red,
                    Fill = System.Windows.Media.Brushes.Red,
                    DataLabels = true,
                    LabelPoint = point => "V:"+point.Y
                },
                new LineSeries
                {
                    Values = new ChartValues<double> { Math.Round(slider10.Value, 2), Math.Round(slider11.Value, 2), Math.Round(slider12.Value, 2), Math.Round(slider13.Value, 2) },
                    Stroke = System.Windows.Media.Brushes.Green,
                },
                new ColumnSeries
                {
                    Values = new ChartValues<double> { Math.Round(slider10.Value, 2), Math.Round(slider11.Value, 2), Math.Round(slider12.Value, 2), Math.Round(slider13.Value, 2) },
                    Stroke = System.Windows.Media.Brushes.Red,
                    Fill = System.Windows.Media.Brushes.Green,
                    DataLabels = true,
                    LabelPoint = point => "I:"+point.Y
                },
                new LineSeries
                {
                    Values = new ChartValues<double> { Math.Round(slider20.Value, 2), Math.Round(slider21.Value, 2), Math.Round(slider22.Value, 2), Math.Round(slider23.Value, 2) },
                    Stroke = System.Windows.Media.Brushes.Blue,
                },
                new ColumnSeries
                {
                    Values = new ChartValues<double> { Math.Round(slider20.Value, 2), Math.Round(slider21.Value, 2), Math.Round(slider22.Value, 2), Math.Round(slider23.Value, 2) },
                    Stroke = System.Windows.Media.Brushes.Red,
                    Fill = System.Windows.Media.Brushes.Blue,
                    DataLabels = true,
                    LabelPoint = point => "T:"+point.Y
                }
            };
        }

        private void Slider00_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
        }
    }
}
