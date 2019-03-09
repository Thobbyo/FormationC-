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
    /// Interaction logic for exo7.xaml
    /// </summary>
    public partial class exo7 : UserControl
    {
        public exo7()
        {
            InitializeComponent();

            listBox.Items.Add("NON !");
            listBox.Items.Add("QUOI !");
            listBox.Items.Add("OK !");
            listBox.Items.Add("SI !");
            listBox.Items.Add("HA OUAI !");
            listBox.Items.Add("HE PHILIPPE !");
        }
    }
}
