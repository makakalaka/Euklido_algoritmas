﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euklido_algoritmas.Backend
{
    public static class Euclidean
    {
        public static List<Computer> data = new List<Computer>();
        public static Computer selectedData = new Computer();


        public static List<Computer> Calculate(double prefPrice, int prefCPU, int prefCores, int prefRAM, int prefSSDorHDD,
            int prefStorage, int prefVRAM, int prefDiagonal, int prefWeight, int prefBatteryCapacity, int prefRefreshRate, 
            List<Computer> listOfComputers, Computer desiredSpecs)
        {
            double ratio = 100 / (prefCPU + prefCores + prefPrice + prefRAM + prefSSDorHDD + prefStorage + prefVRAM + prefDiagonal + prefWeight + prefWeight + prefBatteryCapacity + prefRefreshRate);
            foreach(var computer in listOfComputers)
            {
                computer.setResult(Math.Sqrt(
                    (desiredSpecs.getCPU()-computer.getCPU())* (desiredSpecs.getCPU() - computer.getCPU()) * prefCPU*ratio+
                    (computer.getCores()-desiredSpecs.getCores())* (computer.getCores() - desiredSpecs.getCores())*prefCores *ratio+
                    (computer.getPrice()/1000-desiredSpecs.getPrice()/1000)* (computer.getPrice()/1000 - desiredSpecs.getPrice()/1000)*ratio *prefPrice+
                    (computer.getRAM()-desiredSpecs.getRAM())*(computer.getRAM() - desiredSpecs.getRAM()) * ratio*prefRAM+
                    (Convert.ToInt32(computer.getSSD())- Convert.ToInt32(desiredSpecs.getSSD()))* (Convert.ToInt32(computer.getSSD()) - Convert.ToInt32(desiredSpecs.getSSD())) * ratio *prefSSDorHDD+
                    (computer.getStorageCapacity()/100-desiredSpecs.getStorageCapacity()/100)* (computer.getStorageCapacity()/100 - desiredSpecs.getStorageCapacity()/100) * ratio *prefStorage+
                    (computer.getVRAM()-desiredSpecs.getVRAM())* (computer.getVRAM() - desiredSpecs.getVRAM()) * ratio *prefVRAM+
                    (computer.getDiagonal()-desiredSpecs.getDiagonal())* (computer.getDiagonal() - desiredSpecs.getDiagonal()) * ratio *prefDiagonal+
                    (computer.getWeight()-desiredSpecs.getWeight())* (computer.getWeight() - desiredSpecs.getWeight()) * ratio *prefWeight+
                    (computer.getBatteryCapacity()-desiredSpecs.getBatteryCapacity())* (computer.getBatteryCapacity() - desiredSpecs.getBatteryCapacity()) * ratio *prefBatteryCapacity+
                    (computer.getRefreshRate()/10-desiredSpecs.getRefreshRate()/10)* (computer.getRefreshRate()/10 - desiredSpecs.getRefreshRate()/10) * ratio *prefRefreshRate));
            }
            return listOfComputers;
        }
    }
}
