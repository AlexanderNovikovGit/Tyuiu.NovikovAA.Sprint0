using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.NovikovAA.Sprint0.Task4.V0.Lib;

namespace Tyuiu.NovikovAA.Sprint0.Task4.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.Addition(1, 5));
            Console.WriteLine(DataService.Subtraction(1, 5));
            Console.WriteLine(DataService.Multiplication(5,5));
            Console.WriteLine(DataService.Division(5,5));

            Console.ReadKey();
        }
    }
}
