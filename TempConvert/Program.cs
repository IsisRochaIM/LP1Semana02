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
            Console.Write("Unit (C/F): ");
            string inpU = Console.ReadLine();
        }
    }
}
