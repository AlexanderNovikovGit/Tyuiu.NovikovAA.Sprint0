using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.NovikovAA.Sprint0.Task5.V0.Lib;

namespace Tyuiu.NovikovAA.Sprint0.Task5.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A + B = ", DataService.Addition(5, 5));
            Console.WriteLine("A - B = ", DataService.Subtraction(5, 5));
            Console.WriteLine("A * B = ", DataService.Multiplication(5, 5));
            Console.WriteLine("A / B = ", DataService.Division(5, 0));

            Console.ReadKey();
        }
    }
}
