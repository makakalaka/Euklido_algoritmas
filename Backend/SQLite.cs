using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euklido_algoritmas.Backend
{
    public static class SQLite 
    {
        private static SQLiteConnection m_dbConnection = new SQLiteConnection(@"Data Source=Computers.db;");

        public static List<Computer> FetchComputers()
        {
            
            m_dbConnection.Open();
            
            List<Computer> listOfComputers = new List<Computer>();
            string sql1 = $"SELECT ID,Price,Manufacturor,CPU,Cores,RAM,SSDorHDD,StorageCapacity,VRAM,Diagonal,Weight,BatteryCapacity,RefreshRate FROM Computer";
            SQLiteCommand command1 = new SQLiteCommand(sql1, m_dbConnection);
            
            SQLiteDataReader reader1 = command1.ExecuteReader();


            int ID;
            double price;
            string manufacturor;
            double CPU;
            int cores;
            int RAM;
            int SSD;
            int storageCapacity;
            int vRAM;
            double diagonal;
            double weigh;
            int batteryCapacity;
            int refreshRate;
            

            

            while (reader1.Read())
            {

                ID = reader1.GetInt32(0);
                price = reader1.GetDouble(1);
                manufacturor = reader1.GetString(2);
                CPU = reader1.GetDouble(3);
                cores = reader1.GetInt32(4);
                RAM = reader1.GetInt32(5);
                SSD = reader1.GetInt32(6);
                storageCapacity = reader1.GetInt32(7);
                vRAM = reader1.GetInt32(8);
                diagonal = reader1.GetDouble(9);
                weigh = reader1.GetDouble(10);
                batteryCapacity = reader1.GetInt32(11);
                refreshRate = reader1.GetInt32(12);
                Console.WriteLine(manufacturor);
                bool tempSSD = false;
                if (SSD == 1)
                    tempSSD = true;

                Computer singleComputer = new Computer(ID,manufacturor,price,CPU,cores,RAM,tempSSD,
                    storageCapacity,vRAM,diagonal,weigh,batteryCapacity,refreshRate);
                listOfComputers.Add(singleComputer);
            }
            m_dbConnection.Close();
            return listOfComputers;
        }

        public static List<double> Distinct(string columnName)
        {

            m_dbConnection.Open();

            List<double> listOfValues = new List<double>();
            string sql1 = $"SELECT DISTINCT {columnName} FROM Computer";
            SQLiteCommand command1 = new SQLiteCommand(sql1, m_dbConnection);

            SQLiteDataReader reader1 = command1.ExecuteReader();
            while (reader1.Read())
            {
                
                listOfValues.Add(reader1.GetDouble(0));
            }
            
            m_dbConnection.Close();
            return listOfValues;
        }
        public static List<string> DistinctManufacturors()
        {
            m_dbConnection.Open();

            List<string> listOfValues = new List<string>();
            string sql1 = $"SELECT DISTINCT Manufacturor FROM Computer";
            SQLiteCommand command1 = new SQLiteCommand(sql1, m_dbConnection);

            SQLiteDataReader reader1 = command1.ExecuteReader();
            while (reader1.Read())
            {

                listOfValues.Add(reader1.GetString(0));
            }

            m_dbConnection.Close();
            return listOfValues;
        }
    }
}
