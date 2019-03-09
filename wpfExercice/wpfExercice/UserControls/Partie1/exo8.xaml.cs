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
    /// Interaction logic for exo8.xaml
    /// </summary>
    public partial class exo8 : UserControl
    {
        public exo8()
        {
            InitializeComponent();

            comboBox.Items.Add("NON !");
            comboBox.Items.Add("QUOI !");
            comboBox.Items.Add("OK !");
            comboBox.Items.Add("SI !");
            comboBox.Items.Add("HA OUAI !");
            comboBox.Items.Add("HE PHILIPPE !");
        }
    }
}
