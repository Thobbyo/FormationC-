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
using wpfExercice.UserControls.Partie2;
using wpfExercice.ViewModel;

namespace wpfExercice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }

        private void MenuItem_Click_exo1(object sender, RoutedEventArgs e)
        {
            exo.Content = new Exo1();
        }

        private void MenuItem_Click_exo2(object sender, RoutedEventArgs e)
        {
            exo.Content = new exo2();
        }

        private void MenuItem_Click_exo3(object sender, RoutedEventArgs e)
        {
            exo.Content = new exo3();
        }

        private void MenuItem_Click_exo4(object sender, RoutedEventArgs e)
        {
            exo.Content = new exo4();
        }

        private void MenuItem_Click_exo5(object sender, RoutedEventArgs e)
        {
            exo.Content = new exo5();
        }

        private void MenuItem_Click_exo6(object sender, RoutedEventArgs e)
        {
            exo.Content = new exo6();
        }

        private void MenuItem_Click_exo7(object sender, RoutedEventArgs e)
        {
            exo.Content = new exo7();
        }

        private void MenuItem_Click_exo8(object sender, RoutedEventArgs e)
        {
            exo.Content = new exo8();
        }

        private void MenuItem_Click_exo9(object sender, RoutedEventArgs e)
        {
            exo.Content = new exo9();
        }

        private void MenuItem_Click_MVVMexo1(object sender, RoutedEventArgs e)
        {
            exo.Content = new MVVMexo1();
        }

        private void MenuItem_Click_MVVMexo2(object sender, RoutedEventArgs e)
        {
            exo.Content = new MVVMexo2();
        }

        private void MenuItem_Click_MVVMexo3(object sender, RoutedEventArgs e)
        {
            exo.Content = new MVVMexo3();
        }

        private void MenuItem_Click_MVVMexo4(object sender, RoutedEventArgs e)
        {
            exo.Content = new MVVMexo4();
        }

        private void MenuItem_Click_MVVMexo5(object sender, RoutedEventArgs e)
        {
            exo.Content = new MVVMexo5();
        }

        private void MenuItem_Click_MVVMexo6(object sender, RoutedEventArgs e)
        {
            exo.Content = new MVVMexo6();
        }
    }
}
