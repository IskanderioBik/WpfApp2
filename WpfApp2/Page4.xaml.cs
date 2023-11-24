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
using static System.Math;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        public Page4()
        {
            InitializeComponent();
        }

        private void Math_Click(object sender, RoutedEventArgs e)
        {
            double b = double.Parse(AA.Text);
            double p = double.Parse(BB.Text);
            double a = Cos(b) + 5.1 * Pow(10, -3);
            double w = (Pow(a, 5) + Sin(a * b)) / Sqrt(a * b) + Tan(b);
            double v = Exp(a * w) + p;

            Rez.Text = $"V = {v}\nW = {w}\nA = {a}";
        }
    }
}
