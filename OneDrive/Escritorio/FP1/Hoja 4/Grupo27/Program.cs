using System.Timers;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dime un número y te daré su representación en binario. ");
            int num = int.Parse(Console.ReadLine());
            string binario = "";
            while (num > 0)
            {
                int bit = num % 2;
                binario = bit + binario;
                num /= 2;
            }
            Console.WriteLine("El número en binario es "+ binario);

        }
    }
}