using FizzBuzz.lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzzer fizzBuzzer = new FizzBuzzer();
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(fizzBuzzer.GetValue(i + 1));
            }
            Console.ReadLine();
        }
    }
}
