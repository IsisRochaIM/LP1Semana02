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
                    
                    Console.Write($"{t:f2} C = ");
                    t = t*1.8 + 32;
                    Console.WriteLine($"{t:f2} F");
                    Console.WriteLine($"Absolute value: {Math.Abs(t):f2}");
                    break;
                case "F":
                    
                    Console.Write($"{t:f2} F = ");
                    t = (t - 32)/1.8;
                    Console.WriteLine($"{t:f2} C");

                    Console.WriteLine($"Absolute value: {Math.Abs(t):f2}");
                    break;
                default:
                    Console.WriteLine("Invalid unit.");
                    break;
            }


        }
    }
}
