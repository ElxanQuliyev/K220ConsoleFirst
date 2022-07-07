using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K220ConsoleFirst.models
{
    public class Car
    {
        public string Marka;
        public string Model;
        public decimal FuelEff;//100 mes 15
        public decimal CurrentFuel; //60
        public decimal MaxFuel;//80

        public void GO()
        {
            try
            {
                Console.Write("Nece km getmek isteyirsen?:");
                string neededKm = Console.ReadLine();
                decimal neededKmDesc=Convert.ToDecimal(neededKm);
                if (CurrentFuel>= neededKmDesc/100*FuelEff)
                {
                    CurrentFuel -= neededKmDesc / 100 * FuelEff;
                    Console.WriteLine($"Siz {neededKmDesc}km yol qet etdiniz" +
                        $" masinda {CurrentFuel}l benzin qaldi.");
                }
                else
                {
                    Console.WriteLine("Bu mesafeni bu benzinle hara gedirsen benzin catmir");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Km duzgun daxil et");
            }

        }
    }
}
