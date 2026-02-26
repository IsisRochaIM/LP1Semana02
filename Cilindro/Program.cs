using System;

namespace Cilindro
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Altura: ");
            string inpa = Console.ReadLine();
            double a = Convert.ToDouble(inpa);
            Console.Write("Raio: ");
            string inpr = Console.ReadLine();
            double r = Convert.ToDouble(inpr);
            Console.WriteLine($"{Math.PI*Math.Pow(r,2)*a}");
            double s = 2*Math.PI*r*(r+a);
            Console.WriteLine($"{s:f2}");
        }
    }
}
