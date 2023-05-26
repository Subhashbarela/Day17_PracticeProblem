using Day17_IndianSelciusData;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace IndianSelciusDataNUnitTest
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void LoadDataFromCSV_ShouldThrowException_WhenDelimiterIsIncorrect()
        {
            // Arrange
            string filePath = "C:\\Users\\Shiva027\\Desktop\\BridgeLabsRemapProgram\\Day17_IndianSelciusData\\Day17_IndianSelciusData\\CensusDataFile.csv";
            StateCensusAnalyser analyser = new StateCensusAnalyser(filePath);

            // Act and Assert
            try
            {
                analyser.LoadDataFromCSV(';'); // Use semicolon as delimiter instead of comma
            }
            catch (Exception ex)
            {
                Console.WriteLine("Caught exception: " + ex.Message);
                throw;
            }
        }
    }
}