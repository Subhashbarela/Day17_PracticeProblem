using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day17_IndianSelciusData
{
    public class StateCensusAnalyser
    {
        private string filePath;

        public StateCensusAnalyser(string filePath)
        {
            this.filePath = filePath;
        }


        public int LoadDataFromCSV()
        {
            int numberOfRecords = 0;
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] fields = line.Split(',');

                        numberOfRecords++;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return numberOfRecords;
        }
    }
}

