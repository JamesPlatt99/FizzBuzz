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
            HashSet<string> rules = fizzBuzzer.getRules(args);
            fizzBuzzer.DisplayRuleSet(rules);
            fizzBuzzer.GetOutput(rules);
            foreach(var value in fizzBuzzer)
            {
                Console.WriteLine(value);
            }
            
            Console.ReadLine();
        }
    }
}
