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

namespace A106082063
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void HeightSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double height = Math.Round(HeightSlider.Value, 1);
            HeightNumber.Text = height.ToString();

            double Where = (height / 200) * 340;
            Canvas.SetLeft(Heightwhere, Where);

            double h = double.Parse(HeightNumber.Text);
            double w = double.Parse(WeightNumber.Text);
            double bmi = w / Math.Pow((h / 100), 2);
            string[]parts = Math.Round(bmi,1).ToString().Split('.');

            bmiNumber1.Text = parts[0];
            if (parts.Length > 1)
            {
                bmiNumber2.Text = "." + parts[1];
            }
            else
            {
                bmiNumber2.Text = ".0";
            }
        }

        private void WeightSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double Weight = Math.Round(WeightSlider.Value, 1);
            WeightNumber.Text = Weight.ToString();

            double Where = (Weight / 200) * 340;
            Canvas.SetLeft(Weightwhere, Where);

            double h = double.Parse(HeightNumber.Text);
            double w = double.Parse(WeightNumber.Text);
            double bmi = w / Math.Pow((h / 100), 2);
            string[] parts = Math.Round(bmi, 1).ToString().Split('.');

            bmiNumber1.Text = parts[0];
            if (parts.Length > 1)
            {
                bmiNumber2.Text = "." + parts[1];
            }
            else
            {
                bmiNumber2.Text = ".0";
            }
        }
    }
}
