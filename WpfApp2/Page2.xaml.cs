﻿using System;
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
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void Math_Click(object sender, RoutedEventArgs e)
        {
            double s = double.Parse(AA.Text);
            double D = 2*Sqrt(s / PI);
            double L = PI * D;
            Rez.Text = $"Диаметр = {D}\nДлина окружности = {L}";
        }
    }
}
