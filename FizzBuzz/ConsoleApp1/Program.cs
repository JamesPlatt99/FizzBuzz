using System;
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
            for(int i = 1; i <= 100; i++)
            {
                Console.WriteLine(getOutput(i));
            }
            Console.ReadLine();
        }
        static string getOutput(int i)
        {
            string output = "";
            if (i % 3 == 0)
            {
                output += "Fizz";
            }
            if(i % 5 == 0)
            {
                output += "Buzz";
            }
            if(output == "")
            {
                output = i.ToString();
            }
            return output;
        }
    }
}
