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
                Console.WriteLine(getOutputMethod1(i));
            }
            Console.ReadLine();
        }
        static string getOutputMethod1(int i)
        {
            List<String> outputList = new List<String>();
            string output = "";
            int numSeventeens = 0;

            if (i % 3 == 0)
            {
                outputList.Add("Fizz");
            }
            if(i % 5 == 0)
            {
                outputList.Add("Buzz");
            }
            if(i % 7 == 0)
            {
                outputList.Add("Bang");
            }
            if(i % 13 == 0)
            {
                outputList.Add("Fezz");
            }
            if(i % 17 == 0)
            {
                numSeventeens++;
            }
            if(outputList.Count ==0)
            {
                output = i.ToString();
            }
            else
            {
                if(numSeventeens % 2 == 0)
                {
                    for(int j =0; j < outputList.Count; j++)
                    {
                        output += outputList[j];
                    }
                }
                else
                {

                    for (int j = outputList.Count - 1; j >= 0; j--)
                    {
                        output += outputList[j];
                    }
                }
            }
            return output;
        }

        /*static string getOutputMethod2(int i)
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
        }*/
    }
}
