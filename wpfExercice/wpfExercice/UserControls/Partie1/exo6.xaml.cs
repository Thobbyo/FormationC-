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

namespace wpfExercice
{
    /// <summary>
    /// Interaction logic for exo6.xaml
    /// </summary>
    public partial class exo6 : UserControl
    {
        public exo6()
        {
            InitializeComponent();
            
            StackPanel stackPanel = new StackPanel();
            TextBlock textBlock = new TextBlock();
            textBlock.FontSize = 32;
            textBlock.Text = "Bienvenue en XAML";
            stackPanel.Children.Add(textBlock);
            Button button = new Button();
            button.Content = "Valider";
            button.Click += Button_Click;
            stackPanel.Children.Add(button);
            pouetpouet.Children.Add(stackPanel);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("hello");
        }
    }
}
