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
            //Simple rules - where a string is just added to the end of the output.
            Dictionary<int, String> simpleRules = new Dictionary<int, string>();
            simpleRules.Add(3, "Fizz");
            simpleRules.Add(5, "Buzz");
            simpleRules.Add(7, "Bang");
            foreach (KeyValuePair<int,String> rule in simpleRules)
            {
                if(i % rule.Key == 0 && rules.Contains(rule.Key.ToString()))
                {
                    outputList.Add(rule.Value);
                }
            }

            if (i%13==0 && rules.Contains("13"))
            {
                Boolean found = false;
                for(int j = 0; j<outputList.Count;j++)
                {
                    if(outputList[j].ToCharArray()[0] == 'B')
                    {
                        found = true;
                        outputList[j] = "Fezz" + outputList[j];
                        break;
                    }
                }
                if (!found)
                {
                    outputList.Add("Fezz");
                }
            }
            if (i % 11 == 0 && rules.Contains("11"))
            {
                outputList = new List<string>();
                outputList.Add("Bong");
            }
            if (i % 17 == 0 && rules.Contains("17"))
                {
                    needsReversing = true;
                }
            //Checks if the current number has not met any of the rules
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
