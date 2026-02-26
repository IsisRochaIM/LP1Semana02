using System;

namespace SmoothOperator
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Insere número inteiro: ");
            string input = Console.ReadLine();
            int value = int.Parse(input);
            sbyte n = Convert.ToSByte(value);
            Console.WriteLine(--n);
            Console.WriteLine(++n);

        }
    }
}
