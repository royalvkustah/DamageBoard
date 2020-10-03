using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
using System.Windows.Threading;

namespace DamageBoard
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.IsEnabled = true;
            timer.Tick += (o, t) => { timie.Content = DateTime.Now.ToString(); };
            timer.Start();
        }

        private void run_Click(object sender, RoutedEventArgs e)
        {
            double str = double.Parse(strength.Text);
            double wStr = double.Parse(Wstrength.Text);
            double dMod = double.Parse(dModifier.Text);
            Calculator calculator = new Calculator(str, wStr, dMod);
            resu.Text=calculator.Cacl();
            DateTime dt = new DateTime();
            date.Text = DateTime.Now.ToString();
        }

        private void strength_TextChanged(object sender, TextChangedEventArgs e)
        {


        }

        

        private void Wstrength_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void dModifier_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void result_TextChanged(object sender, TextChangedEventArgs e)
        {


        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
