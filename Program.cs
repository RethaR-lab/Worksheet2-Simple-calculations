using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of units consumed: ");
            int iUnits = int.Parse(Console.ReadLine());

            Console.Write("Enter cost per unit: ");
            double dCostPerUnit = double.Parse(Console.ReadLine());

            double dSubTotal = iUnits * dCostPerUnit;
            double dVAT = dSubTotal * 0.15;
            double dTotalCost = dSubTotal + dVAT;
           
            Console.WriteLine("\nElectricity Bill Summary");
            Console.WriteLine("------------------------");

            Console.WriteLine($"Subtotal: R{dSubTotal:F2}");
            Console.WriteLine($"VAT (15%): R{dVAT:F2}");
            Console.WriteLine($"Total Cost: R{dTotalCost:F2}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
