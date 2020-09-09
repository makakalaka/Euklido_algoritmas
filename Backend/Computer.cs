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
        private double price;
        private string manufacturor;
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
        public Computer()
        {

        }
        public Computer(int ID1,string manufacturor1, double price1, double CPU1,int cores1, int RAM1, bool SSD1, int storageCapacity1,
            int vRAM1, double diagonal1, double weight1, int batteryCapacity1, int refreshRate1)
        {
            ID = ID1;
            manufacturor = manufacturor1;
            price = price1;
            CPU = CPU1;
            cores = cores1;
            RAM = RAM1;
            SSD = SSD1;
            storageCapacity = storageCapacity1;
            vRAM = vRAM1;
            diagonal = diagonal1;
            weight = weight1;
            batteryCapacity = batteryCapacity1;
            refreshRate = refreshRate1;
        }
    
        public void setID(int id)
        {
            ID = id;
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
