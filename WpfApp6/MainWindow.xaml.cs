using System;
using System.Collections.Generic;
using System.Data;
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

namespace WpfApp6
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
        static double Function(double x)
        {
            return (x - 900) * Math.Pow(Math.E, -(x / 500)) * Math.Sin(x / 100);
            
        }

        static double Bisection(double a, double b, double tolerance) {
            double c = a;
            while ((b - a) / 2.0 > tolerance)
            {
                c = (a + b) / 2;
                if (Function(c) == 0.0)
                {
                    break;
                }
                else if (Function(a) * Function(c) < 0)
                {
                    b = c;
                }
                else
                {
                    a = c;
                }
            }
            return c;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double a = Convert.ToDouble(prz1.Text);
            double b = Convert.ToDouble(prz2.Text);

            double tolerance = Convert.ToDouble(dop.Text);

            double pointZero = Bisection(a, b, tolerance);

            txtzero.Text = pointZero.ToString();
        }
      

        
    }
}



