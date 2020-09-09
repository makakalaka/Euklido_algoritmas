using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euklido_algoritmas.Backend
{
   public class Computer
    {
        private int ID;
        private string manufacturor;
        private double CPU;
        private int cores;
        private int RAM;
        private bool SSD;
        private int storageCapacity;
        private int vRAM;
        private double diagonal;
        private double weigh;
        private int batteryCapacity;
        private int refreshRate;
        private double result;
        public Computer()
        {

        }
        public Computer(int ID1,string manufacturor1,double CPU1,int cores1, int RAM1, bool SSD1, int storageCapacity1,
            int vRAM1, double diagonal1, double weight1, int batteryCapacity1, int refreshRate1)
        {
            this.ID1 = ID1;
            this.Manufacturor = manufacturor1;
            this.CPU1 = CPU1;
            this.Cores = cores1;
            this.RAM1 = RAM1;
            this.SSD1 = SSD1;
            this.StorageCapacity = storageCapacity1;
            this.VRAM = vRAM1;
            this.Diagonal = diagonal1;
            this.Weigh = weight1;
            this.BatteryCapacity = batteryCapacity1;
            this.RefreshRate = refreshRate1;
        }

        public int ID1 { get => ID; set => ID = value; }
        public string Manufacturor { get => manufacturor; set => manufacturor = value; }
        public double CPU1 { get => CPU; set => CPU = value; }
        public int Cores { get => cores; set => cores = value; }
        public int RAM1 { get => RAM; set => RAM = value; }
        public bool SSD1 { get => SSD; set => SSD = value; }
        public int StorageCapacity { get => storageCapacity; set => storageCapacity = value; }
        public int VRAM { get => vRAM; set => vRAM = value; }
        public double Diagonal { get => diagonal; set => diagonal = value; }
        public double Weigh { get => weigh; set => weigh = value; }
        public int BatteryCapacity { get => batteryCapacity; set => batteryCapacity = value; }
        public int RefreshRate { get => refreshRate; set => refreshRate = value; }
        public double Result { get => result; set => result = value; }
    }
}
