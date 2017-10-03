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

        static string getOutputMethod2(int i)
        {

            //if(i%5==0 && i % 3 == 0)
            //{
            //    return "FizzBuzz";
            //}
            //Simplified version, all factors of both 5 and 3 must be factors of 15 (5 * 3)
            if (i % 15 == 0)
            {
                return "FizzBuzz";
            }
            if(i % 5 == 0)
            {
                return "Buzz";
            }
            if(i % 3 == 0)
            {
                return "Fizz";
            }
            return i.ToString();
        }
        
    }
}
