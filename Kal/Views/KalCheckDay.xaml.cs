using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace Kal.Views
{
    public partial class KalCheckDay : Window
    {
        public KalCheckDay()
        {
            InitializeComponent();

            SolidColorBrush animatedBrush = new SolidColorBrush(Colors.LightBlue);

            VeryCool.Background = animatedBrush;

            ColorAnimation colorAnimation = new ColorAnimation
            {
                To = Colors.Green,
                Duration = new Duration(TimeSpan.FromSeconds(1)),
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever
            };
            animatedBrush.BeginAnimation(SolidColorBrush.ColorProperty, colorAnimation);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow wind = new MainWindow();
            wind.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow wind = new MainWindow();
            wind.Show();
            Close();
        }
    }
}