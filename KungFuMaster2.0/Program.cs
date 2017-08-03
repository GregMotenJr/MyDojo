using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KungFuMaster2._0
{
    // The Apprentice Soon Shall Become The Master
    // my work space for kata practice

    class Program
    {
        static void Main(string[] args)
        {
            ///Title: Words from text

            ///Instructions:

            /*
             * Generate a count of the occurrences of each word for this text. 
             * Output a list of words and counts in descending count order
             * (word with highest count listed first)
             */

            //Establish initial variables
            string srcFile = ("C:\\Users\\jiggy\\OneDrive\\Documents\\Visual Studio 2015\\Projects\\testing\\testing\\text.txt");
            string input = File.ReadAllText(srcFile);

            //Make case Insensitive
            input = input.ToLower();

            //Remove certain chars
            string[] removeChars = { ";", ",", ".", "-", "_", "^", "(", ")", "[", "]",
                        "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "\n", "\t", "\r" };
            foreach (string character in removeChars)
            {
                input = input.Replace(character, "");
            }

            //Create a List of the words
            List<string> wordList = input.Split(' ').ToList();


            //Create a new Dictionary of the words and their count
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            foreach (string word in wordList)
            {
                if (dictionary.ContainsKey(word))
                {
                    dictionary[word]++;
                }
                else
                {
                    dictionary[word] = 1;
                }
            }

            //Sort by descending value
            var sortedDictionary = (from entry in dictionary orderby entry.Value descending select entry).ToDictionary(pair => pair.Key, pair => pair.Value);

            //output the results
            int count = 1;
            foreach (KeyValuePair<string, int> pair in sortedDictionary)
            {
                Console.WriteLine("{0}: The word \"{1}\" is shown {2} times", count, pair.Key, pair.Value);
                count++;
            }

            Console.ReadKey();

        }//END Main

    }//END Program
}
