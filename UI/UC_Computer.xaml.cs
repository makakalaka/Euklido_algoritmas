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

namespace Euklido_algoritmas.UI
{
    /// <summary>
    /// Interaction logic for UC_Computer.xaml
    /// </summary>
    public partial class UC_Computer : UserControl
    {
        private int ID;
        private string manufacturor;
        private double price;
        private double CPU;
        private int cores;
        private int RAM;
        private bool SSD;
        private int storageCapacity;
        private int vRAM;
        private double diagonal;
        private double weight;
        private int batteryCapacity;
        private int refreshRate;
        private double result;

        public UC_Computer()
        {
            InitializeComponent();
        }
        public UC_Computer(int ID1, string manufacturor1,double price1, double CPU1, int cores1, int RAM1, bool SSD1, int storageCapacity1,
            int vRAM1, double diagonal1, double weight1, int batteryCapacity1, int refreshRate1)
        {
            InitializeComponent();
            ID = ID1;
            this.lbl_ID.Content = ID1;
            manufacturor = manufacturor1;
            this.lbl_manufacturor.Content = manufacturor;
            price = price1;
            this.lbl_price.Content = price;
            CPU = CPU1;
            this.lbl_CPU.Content = CPU;
            cores = cores1;
            this.lbl_cores.Content = cores;
            RAM = RAM1;
            this.lbl_ram.Content = RAM;
            SSD = SSD1;
            this.lbl_SSD.Content = SSD;
            storageCapacity = storageCapacity1;
            this.lbl_storageCapacity.Content = storageCapacity;
            vRAM = vRAM1;
            this.lbl_vRAM.Content = vRAM;
            diagonal = diagonal1;
            this.lbl_diagonal.Content = diagonal;
            weight = weight1;
            this.lbl_weigh.Content = weight;
            batteryCapacity = batteryCapacity1;
            this.lbl_batteryCapacity.Content = batteryCapacity;
            refreshRate = refreshRate1;
            this.lbl_refreshRate.Content = refreshRate;
        }

        public void setID(int id)
        {
            ID = id;
            this.lbl_ID.Content = id;
        }
        public int getID()
        {
            return ID;
        }
        public void setManufacturor(string man)
        {
            manufacturor = man;
        }
        public string getManufacturor()
        {
            return manufacturor;
        }
        public void setPrice(double cost)
        {
            price = cost;
        }
        public double getPrice()
        {
            return price;
        }
        public void setCPU(double cpu)
        {
            CPU = cpu;
        }
        public double getCPU()
        {
            return CPU;
        }
        public void setCores(int coreNumber)
        {
            cores = coreNumber;
        }
        public int getCores()
        {
            return cores;
        }
        public void setRAM(int ram)
        {
            RAM = ram;
        }
        public int getRAM()
        {
            return RAM;
        }
        public void setSSD(bool ssd)
        {
            SSD = ssd;
        }
        public bool getSSD()
        {
            return SSD;
        }
        public void setStorageCapacity(int sc)
        {
            storageCapacity = sc;
        }
        public int getStorageCapacity()
        {
            return storageCapacity;
        }
        public void setVRAM(int vram)
        {
            vRAM = vram;
        }
        public int getVRAM()
        {
            return vRAM;
        }
        public void setDiagonal(double diag)
        {
            diagonal = diag;
        }
        public double getDiagonal()
        {
            return diagonal;
        }
        public void setWeight(double kg)
        {
            weight = kg;
        }
        public double getWeight()
        {
            return weight;
        }
        public void setBatteryCapacity(int bc)
        {
            batteryCapacity = bc;
        }
        public int getBatteryCapacity()
        {
            return batteryCapacity;
        }
        public void setRefreshRate(int rr)
        {
            refreshRate = rr;
        }
        public int getRefreshRate()
        {
            return refreshRate;
        }
        public void setResult(double res)
        {
            result = res;
        }
        public double getResult()
        {
            return result;
        }


    }
}
