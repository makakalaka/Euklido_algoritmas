using Euklido_algoritmas.Backend;
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

namespace Euklido_algoritmas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<ComboBox> comboBoxes = new List<ComboBox>();
        List<ComboBox> comboBoxesSpecs = new List<ComboBox>();
        List<Computer> listOfComputers;
        List<UI.UC_Computer> computer_user_controls = new List<UI.UC_Computer>();
        List<Computer> pcs;

        public MainWindow()
        {
            InitializeComponent();
            FillStartup();
        }

        public void FillPreset(List<ComboBox> cboxes)
        { 
            foreach(var box in cboxes)
            {
                box.SelectedIndex = 2;
            }
        }
        public void FillStartup()
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
            comboBoxes.Add(cb_refresh_rate_Copy);
            PreferencesValues values = new PreferencesValues();
            for (int i = 0; i < values.GetPreferences.Length; i++)
            {
                for (int j = 0; j < comboBoxes.Count; j++)
                {
                    comboBoxes[j].Items.Add(values.GetPreferences[i]);
                }
            }
            FillPreset(comboBoxes);
            listOfComputers = SQLite.FetchComputers();
            FillUC(listOfComputers);
            comboBoxesSpecs.Add(par_BATTERY);
            comboBoxesSpecs.Add(par_Cores);
            comboBoxesSpecs.Add(par_CPU);
            comboBoxesSpecs.Add(par_DIAG);
            comboBoxesSpecs.Add(par_RAM);
            comboBoxesSpecs.Add(par_REFRESH);
            comboBoxesSpecs.Add(par_SDDHDD);
            comboBoxesSpecs.Add(par_Sorage);
            comboBoxesSpecs.Add(par_VRAM);
            comboBoxesSpecs.Add(par_Weigh);
            List<double> tempValues = new List<double>();
            string[] specValues = { "BatteryCapacity", "Cores", "CPU", "Diagonal", "RAM", "RefreshRate", "SSDorHDD", "StorageCapacity", "VRAM", "Weight"};
            for(int j=0;j<specValues.Length;j++)
            {
                tempValues = SQLite.Distinct(specValues[j]);
                tempValues.Sort();
                foreach (var i in tempValues)
                    comboBoxesSpecs[j].Items.Add(i);
                tempValues.Clear();
            }
            List<string> tempManufacturors = SQLite.DistinctManufacturors();
            foreach (var i in tempManufacturors)
                comboBoxFilterManufacturor.Items.Add(i);
            tempManufacturors.Clear();
        }

        public void FillUC(List<Computer> listOfComputers)
        {
            computer_user_controls.Clear();
            stackPanelComputers.Children.Clear();
            for (int i = 0; i < listOfComputers.Count; i++)
            {
                Console.WriteLine("ID " + listOfComputers[i].getID());
                UI.UC_Computer singleUserControl = new UI.UC_Computer(listOfComputers[i].getID(), listOfComputers[i].getManufacturor(),
                    listOfComputers[i].getPrice(), listOfComputers[i].getCPU(), listOfComputers[i].getCores(), listOfComputers[i].getRAM(),
                    listOfComputers[i].getSSD(), listOfComputers[i].getStorageCapacity(), listOfComputers[i].getVRAM(), listOfComputers[i].getDiagonal(),
                    listOfComputers[i].getWeight(), listOfComputers[i].getBatteryCapacity(), listOfComputers[i].getRefreshRate(),listOfComputers[i].getResult());

                computer_user_controls.Add(singleUserControl);
            }
            for (int i = 0; i < computer_user_controls.Count; i++)
            {
                stackPanelComputers.Children.Add(computer_user_controls[i]);
            }
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            if (txtPrice.Text.Length > 0)
            {
                if (cb_CPU.SelectedIndex != -1 || cb_cores.SelectedIndex != -1 || cb_RAM.SelectedIndex != -1 ||
                    cb_SSDorHDD.SelectedIndex != -1 || cb_Storage.SelectedIndex != -1 || cb_vRam.SelectedIndex != -1 ||
                     cb_diagonal.SelectedIndex != -1 || cb_weight.SelectedIndex != -1 || cb_battery_capacity.SelectedIndex != -1 ||
                      cb_refresh_rate.SelectedIndex != -1 || par_CPU.SelectedIndex != -1 || par_Cores.SelectedIndex != -1 ||
                      par_RAM.SelectedIndex != -1 || par_SDDHDD.SelectedIndex != -1 || par_Sorage.SelectedIndex != -1 ||
                      par_VRAM.SelectedIndex != -1 || par_DIAG.SelectedIndex != -1 || par_Weigh.SelectedIndex != -1 ||
                      !par_BATTERY.SelectedIndex.Equals(-1)  || !par_REFRESH.SelectedIndex.Equals(-1))
                {
                    int prefPrice = cb_refresh_rate_Copy.SelectedIndex + 1;
                    int prefCPU = cb_CPU.SelectedIndex + 1;
                    int prefCores = cb_cores.SelectedIndex + 1;
                    int prefRAM = cb_RAM.SelectedIndex + 1;
                    int prefSSDorHDD = cb_SSDorHDD.SelectedIndex + 1;
                    int prefStorage = cb_Storage.SelectedIndex + 1;
                    int prefVRAM = cb_vRam.SelectedIndex + 1;
                    int prefDiagonal = cb_diagonal.SelectedIndex + 1;
                    int prefWeight = cb_weight.SelectedIndex + 1;
                    int prefBatteryCapacity = cb_battery_capacity.SelectedIndex + 1;
                    int prefRefreshRate = cb_refresh_rate.SelectedIndex + 1;
                    Computer desiredSpecs = new Computer();
                    desiredSpecs.setBatteryCapacity(Convert.ToInt32(par_BATTERY.SelectedItem));
                    desiredSpecs.setCores(Convert.ToInt32(par_Cores.SelectedItem));
                    desiredSpecs.setCPU(Convert.ToDouble(par_CPU.SelectedItem));
                    desiredSpecs.setDiagonal(Convert.ToDouble(par_DIAG.SelectedItem));
                    desiredSpecs.setRAM(Convert.ToInt32(par_RAM.SelectedItem));
                    desiredSpecs.setRefreshRate(Convert.ToInt32(par_REFRESH.SelectedItem));
                    desiredSpecs.setVRAM(Convert.ToInt32(par_VRAM.SelectedItem));
                    desiredSpecs.setWeight(Convert.ToDouble(par_Weigh.SelectedItem));
                    desiredSpecs.setSSD(Convert.ToBoolean(par_SDDHDD.SelectedItem));
                    desiredSpecs.setStorageCapacity(Convert.ToInt32(par_Sorage.SelectedItem));
                    desiredSpecs.setPrice(Convert.ToDouble(txtPrice.Text));
                    pcs = Euclidean.Calculate(prefPrice, prefCPU, prefCores, prefRAM, prefSSDorHDD, prefStorage, prefVRAM, prefDiagonal,
                       prefWeight, prefBatteryCapacity, prefRefreshRate, listOfComputers, desiredSpecs);
                    pcs.Sort((x, y) => x.getResult().CompareTo(y.getResult()));
                    FillUC(pcs);
                }
                else
                {
                    MessageBox.Show("Neįrašėte pasirinkimų");
                }
            }
            else
            {
                MessageBox.Show("Neįrašėte kainos");
            }
        }

        private void checkBox_filtras_Checked(object sender, RoutedEventArgs e)
        {
            comboBoxFilterManufacturor.IsEnabled = true;
            lblFilerManufacturor.IsEnabled = true;
        }

        private void checkBox_filtras_Unchecked(object sender, RoutedEventArgs e)
        {
            comboBoxFilterManufacturor.SelectedIndex = -1;
            comboBoxFilterManufacturor.IsEnabled = false;
            lblFilerManufacturor.IsEnabled = false;
            if (pcs != null)
            {
                stackPanelComputers.Children.Clear();
                FillUC(pcs);
            }
            else
            {
                stackPanelComputers.Children.Clear();
                FillUC(listOfComputers);
            }
        }

        private void comboBoxFilterManufacturor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (checkBox_filtras.IsChecked == true)
            {

                List<Computer> selectedManufactorComputers = new List<Computer>();
                string selectedManufacturor = comboBoxFilterManufacturor.SelectedItem.ToString();
                if (pcs != null)
                {
                     stackPanelComputers.Children.Clear();
                    for (int i = 0; i < pcs.Count; i++)
                    {
                        if (pcs[i].getManufacturor() == selectedManufacturor)
                        {
                            selectedManufactorComputers.Add(pcs[i]);
                            
                        }
                    }
                    
                }
                else
                {
                    stackPanelComputers.Children.Clear();
                    for (int i = 0; i < listOfComputers.Count; i++)
                    {
                        if (listOfComputers[i].getManufacturor() == selectedManufacturor)
                        {
                            selectedManufactorComputers.Add(listOfComputers[i]);
                            
                        }
                    }
                    
                }
                FillUC(selectedManufactorComputers);
            }
            
        }
    }
}
