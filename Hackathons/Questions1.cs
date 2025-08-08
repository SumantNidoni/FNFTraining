using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathons
{
    internal class Questions1
    {
        static void Main(string[] args)
        {
            //------------------First Program------------------
            Console.WriteLine("Enter the sentence");
            List<string> res = WordFrequencyCounter(Console.ReadLine().ToLower());
            foreach (string s in res)
            {
                Console.WriteLine(s);
            }
        }


        public static List<string> WordFrequencyCounter(string input)
        {
            List<string> output = new List<string>();

            bool hasLetter = false;
            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    hasLetter = true;
                    break;
                }
            }

            if (!hasLetter)
            {
                output.Add("0");
                return output;
            }



            char[] seperators = { ' ', '.', ',', '?', '!', ';', ':', '-', '\t', '\n' };

            string[] words = input.Split(seperators, StringSplitOptions.RemoveEmptyEntries);


            Dictionary<string, int> frequency = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (frequency.ContainsKey(word))
                {
                    frequency[word]++;
                }
                else
                {
                    frequency[word] = 1;
                }
            }


            List<KeyValuePair<string, int>> wordList = new List<KeyValuePair<string, int>>(frequency);


            wordList.Sort((a, b) =>
            {
                int freqCompare = b.Value.CompareTo(a.Value);
                return freqCompare != 0 ? freqCompare : string.Compare(b.Key, a.Key);
            });

            foreach (var pair in wordList)
            {
                output.Add($"{pair.Value} {pair.Key}");
            }
            return output;
        }

    }
}
