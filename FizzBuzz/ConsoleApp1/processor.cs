using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class processor : IEnumerable<String>
    {
        private List<String> _outputs = new List<String>();

        public void Start(string[] args)
        {
            processor fizzBuzzer = new processor();
            HashSet<string> rules = fizzBuzzer.getRules(args);
            DisplayRuleSet(rules);

            int maxNumber = GetMaxNumber();

            for (int i = 1; i <= maxNumber; i++)
            {
                GetOutput(i, rules);
            }
        }

        private void GetOutput(int i, HashSet<String> rules)
        {            
                List<String> outputList = new List<String>();
                string output = "";
                Boolean needsReversing = false;

                if (i % 3 == 0 && rules.Contains("3"))
                {
                    outputList.Add("Fizz");
                }
                if (i % 5 == 0 && rules.Contains("5"))
                {
                    outputList.Add("Buzz");
                }
                if (i % 7 == 0 && rules.Contains("7"))
                {
                    outputList.Add("Bang");
                }
                if (i % 11 == 0 && rules.Contains("11"))
                {
                    outputList.Add("Bong");
                }
                if (i % 13 == 0 && rules.Contains("13"))
                {
                    outputList.Add("Fezz");
                }
                if (i % 17 == 0 && rules.Contains("17"))
                {
                    needsReversing = true;
                }
                if (outputList.Count == 0)
                {
                    output = i.ToString();
                }
                else
                {
                    //Checks whether list needs to be reversed
                    if (!needsReversing)
                    {
                        for (int j = 0; j < outputList.Count; j++)
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
                _outputs.Add(output);
        }

        private HashSet<String> getRules(string[] args)
        {
            HashSet<string> rules = new HashSet<string>();

            foreach (string rule in args)
            {
                rules.Add(rule);
            }
            return rules;
        }

        private void DisplayRuleSet(HashSet<String> rules)
        {
            Console.WriteLine("Ruleset: ");
            foreach (string rule in rules)
            {
                Console.WriteLine("  {0}", rule);
            }
        }

        public int GetMaxNumber()
        {
            Console.Write("Please enter the max number: ");
            string input;
            input = Console.ReadLine();
            int output;
            while (!int.TryParse(input, out output))
            {
                Console.WriteLine("Sorry, that value is invalid. Please try again.");
                Console.Write("Please enter the max number: ");
                input = Console.ReadLine();
            }
            return output;
        }

        public IEnumerator<string> GetEnumerator()
        {
            return _outputs.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
