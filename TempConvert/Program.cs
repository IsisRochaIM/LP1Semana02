using System;
using System.Globalization;

namespace TempConvert
{
    public class Program
    {
        private static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            Console.Write("Temperature: ");
            string inpT = Console.ReadLine();
            double t = Convert.ToDouble(inpT);
            Console.Write("Unit (C/F): ");
            string inpU = Console.ReadLine();

            switch(inpU)
            {
                case "C":
                    t = t*1.8 + 32;
                    Console.WriteLine($"{inpT} C = {t:f2} F");
                    break;
                case "F":
                    t = (t - 32)/1.8;
                    Console.WriteLine($"{inpT} F = {t:f2} C");
                    break;
            }
        }
    }
}
