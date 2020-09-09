using Euklido_algoritmas.Backend;
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

namespace Euklido_algoritmas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<ComboBox> comboBoxes = new List<ComboBox>();

        public MainWindow()
        {
            InitializeComponent();
            FillPreferences();
        }

        public void FillPreferences()
        {
            comboBoxes.Add(cb_CPU);
            comboBoxes.Add(cb_battery_capacity);
            comboBoxes.Add(cb_cores);
            comboBoxes.Add(cb_diagonal);
            comboBoxes.Add(cb_RAM);
            comboBoxes.Add(cb_refresh_rate);
            comboBoxes.Add(cb_SSDorHDD);
            comboBoxes.Add(cb_Storage);
            comboBoxes.Add(cb_vRam);
            comboBoxes.Add(cb_weight);

            PreferencesValues values = new PreferencesValues();
            for (int i = 0; i < values.GetPreferences.Length; i++)
            {
                for(int j=0;j<comboBoxes.Count;j++)
                {
                    comboBoxes[j].Items.Add(values.GetPreferences[i]);
                }
            }
        }
    }
}
