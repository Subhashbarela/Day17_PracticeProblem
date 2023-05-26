using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day17_IndianSelciusData
{
    public class Program
    {
        static void Main(string[] args)
        {
            string filePath = "C:\\Users\\Shiva027\\Desktop\\BridgeLabsRemapProgram\\Day17_IndianSelciusData\\Day17_IndianSelciusData\\CensusDataFile.csv";
            StateCensusAnalyser analyser = new StateCensusAnalyser(filePath);
            int numberOfRecords = analyser.LoadDataFromCSV();
            Console.WriteLine("Number of records in the file: " + numberOfRecords);
            Console.ReadLine();
        }
    }
}
