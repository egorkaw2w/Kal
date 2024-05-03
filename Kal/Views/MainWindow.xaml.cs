using Kal.Views;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            DoubleAnimation cool = new DoubleAnimation();
            cool.From = CoolKnopka.ActualHeight;
            cool.To = 150;
            cool.Duration = TimeSpan.FromSeconds(3.14);
            cool.AutoReverse = true;
            cool.RepeatBehavior = RepeatBehavior.Forever;

            CoolKnopka.BeginAnimation(Button.HeightProperty, cool); 

            DoubleAnimation cool2 = new DoubleAnimation();
            cool2.From = NotCoolButton.ActualWidth;
            cool2.To = 369;
            cool2.Duration = TimeSpan.FromSeconds(3.15);
            cool2.RepeatBehavior = RepeatBehavior.Forever;
            cool2.AutoReverse = true;
            NotCoolButton.BeginAnimation(Button.WidthProperty, cool2);
        }

        private void KalDay_MouseDown(object sender, MouseButtonEventArgs e)
        {
            KalCheckDay windo = new KalCheckDay();
            windo.Show();
            Close();
        }


    }
}