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
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Page
    {

        double volts = 12;
        double capacity = 500;
        int initSOC = 100;
        int totalKm = 0;

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            string s = Accelerate.Value.ToString();
            Accelerate.ToolTip = (Accelerate.Value * 10);
            //acc.Content = Accelerate.Value * 10;
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            double resistance = Math.Round(Accelerate.Value, 2) * 0.1;
            double current = volts / resistance;

            int soc = (int)(initSOC + ((current * -1) / this.capacity) * timeSlide.Value * 100);

            int dod = initSOC - soc;

            double hr = (soc * timeSlide.Value) / dod;

            double km = (resistance * 100) * hr;

            totalKm += (int)((resistance * 100) * timeSlide.Value);

            initSOC = soc;

            if (initSOC > 0) { 
            changes.Content = "Current Used : " + Math.Ceiling(current) + "\nState Of Charge :" + soc + "\nDischarge :" + dod
                + "\nRemained Battery hours :" + Math.Ceiling(hr) + "\nKm in remained Battery :" + Math.Ceiling(km)
                + "\nTotal Km run :" + totalKm;
            }
            else {
                changes.Content = "Battery is totally drained need to be charged.";
                timeSlide.Value = 0.1;
                Accelerate.Value = 0.1;
                initSOC = 100;
            }

        }

        private void TimeSlide_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            timeSlide.ToolTip = timeSlide.Value * 10;
        }
    }
}
