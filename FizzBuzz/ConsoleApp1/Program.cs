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
            while (true) { 
                Console.WriteLine("Fizz Buzz");
                Console.WriteLine("   1. IEnumerable interface challenge");
                Console.WriteLine("   2. One Liner challenge");
                Console.WriteLine("   3. One Liner v2");
                String input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        IEnumerableChallenge(args);
                        break;
                    case "2":
                        OneLiner();
                        break;
                    case "3":
                        OneLinerV2();
                        break;
                }
                Console.WriteLine();
                Console.WriteLine();
            }            
        }

        private static void IEnumerableChallenge(string[] args)
        {
            processor fizzBuzzer = new processor();
            fizzBuzzer.Start(args);

            foreach (var value in fizzBuzzer)
            {
                Console.WriteLine(value);
            }
        }
        private static void OneLiner()
        {
            Boolean validInput = false;
            while (!validInput) { 
                Console.Write("Please enter your max value: ");
                try
                {
                    validInput = true;
                    //Here's the one line that it needs
                    Enumerable.Range(1, Convert.ToInt32(Console.ReadLine())).Select(n => (n % 15 == 0) ? "FizzBuzz" : (n % 3 == 0) ? "Fizz" : (n % 5 == 0) ? "Buzz" : n.ToString()).ToList().ForEach(Console.WriteLine);
                }
                catch
                {
                    Console.WriteLine("Invalid input, please try again.");
                    validInput = false;
                }
            }
        }
        public static void OneLinerV2()
        {
            Dictionary<int,String> rules = new Dictionary<int,string>();
            Console.WriteLine("Please choose a ruleset: ");
            Console.WriteLine(" 1. Write me a wicked new rap song");
            Console.WriteLine(" 2. Normal");
            if (Console.ReadLine() == "1")
            {
                rules.Add(72, "Bang");
                rules.Add(8, "Boom");
                rules.Add(9, "Zoom");
                rules.Add(10, "Pow");
                rules.Add(11, "Sha'taang");
                rules.Add(12, "Nyyuuuuum");
                rules.Add(13, "KAPLAAAAAR");
                rules.Add(14, "PopPop");
                rules.Add(15, "Bing");
                rules.Add(16, "Shiddy");
                rules.Add(2, "Bong");
                rules.Add(4, "JustSauce");
                rules.Add(7, "DaTingGoes");
                rules.Add(6, "NoKetchup");
                rules.Add(1, "Skkrrrrat");
            }
            rules.Add(3, "Fizz");
            rules.Add(5, "Buzz");
            String x;

            Boolean validInput = false;
            while (!validInput)
            {
                try { 
                    Console.Write("Please enter your max value: ");
                    
                    validInput = true;
                    //Enumerable.Range(1, Convert.ToInt32(Console.ReadLine())).Select(n => (x = String.Join("" , rules.Where( a => n % a.Key == 0).Select(b=> b.Value))) == "" ? n.ToString() : x).ToList().ForEach(Console.WriteLine);
                    Enumerable.Range(1, Convert.ToInt32(Console.ReadLine())).Select(
                        i => Tuple.Create(i, string.Join("", rules.Where(rule => i % rule.Key == 0).Select(rule => rule.Value))))
                        .Select(p => p.Item2 == "" ? p.Item1.ToString() : p.Item2)
                        .ToList()
                        .ForEach(Console.WriteLine);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    validInput = false;
                }
            }
        }
        
    }
}
