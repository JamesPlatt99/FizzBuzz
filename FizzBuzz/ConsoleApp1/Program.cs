using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            processor fizzBuzzer = new processor();
            fizzBuzzer.Start(args);

            foreach(var value in fizzBuzzer)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine();
            Console.WriteLine();

            IEnumerable<string> fizzBuzz = Enumerable.Range(1, 100).Select(n => (n % 15 == 0) ? "FizzBuzz" : (n % 3 == 0) ? "Fizz" : (n % 5 == 0) ? "Buzz" : n.ToString()).ToList();
            foreach(string output in fizzBuzz)
            {
                Console.WriteLine(output);
            }
            Console.ReadLine();
        }
    }
}
