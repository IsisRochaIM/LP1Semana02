using System;

namespace VariousOperators
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string inp = Console.ReadLine();
            byte bt = byte.Parse(inp);
            Console.WriteLine($"{bt/2}");
            Console.WriteLine($"{bt<<3}");
            Console.WriteLine($"{bt^6}");
            Console.WriteLine($"{bt>10}");
            
        }
    }
}
