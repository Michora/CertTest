using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!\n\n");
            Console.Write("Введите число A: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите число B: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("A + B = " + (a + b));
            Console.WriteLine("A - B = " + (a - b));
            Console.WriteLine("A * B = " + (a * b));
            Console.WriteLine("A / B = " + (a / b));
            Console.ReadKey();
        }
    }
}