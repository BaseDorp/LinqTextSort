using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            // Directory that the text file is going to be read in from
            string textFile = Directory.GetCurrentDirectory() + @"\words.txt";
            string[] words = File.ReadAllLines(textFile);

            Console.WriteLine("1. Sort list from Z-A\n2. Return all words starting with 'Z'\n3. Return all words that start with 'He'\n4. Return all words that the second letter is an 'e'\n");
            string input;
            input = Console.ReadLine();
            Console.Clear();
            switch (input)
            {
                case "1":
                    ReverseSort();
                    break;
                case "2":
                    StringStartsWith("Z");
                    break;
                case "3":
                    StringStartsWith("He");
                    break;
                case "4":
                    SecondLetter();
                    break;
                default:
                    // Default path in case user types in not a valid number
                    ReverseSort();
                    break;
            }

            // Sort list from Z-A
            void ReverseSort()
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                for (int i = words.Length - 1; i > -1; i--)
                {
                    Console.WriteLine(words[i]);
                }
                stopWatch.Stop();
                FormatTime(stopWatch.Elapsed);
            }

            // Return all words that start with a letter
            // Part 2 and 3 use the same code so I just use the same method
            void StringStartsWith(string _letter)
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                //Code sourced from http://www.java2s.com/Tutorial/CSharp/0450__LINQ/LINQquerytogetstringsstartingwiths.htm
                var queryResults =
                    from n in words
                    where n.StartsWith(_letter)
                    select n;

                foreach (var item in queryResults)
                {
                    Console.WriteLine(item);
                }
                stopWatch.Stop();
                FormatTime(stopWatch.Elapsed);
            }

            // Return all words that the second letter is an 'e'
            void SecondLetter()
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                // Source code from https://stackoverflow.com/questions/43413889/how-to-select-a-name-that-contains-the-second-letter-is-s-using-linq
                var result = words.Where(s => s.Length > 1 && s[1] == 'e');
                foreach (var item in result)
                {
                    Console.WriteLine(item);
                }
                stopWatch.Stop();
                FormatTime(stopWatch.Elapsed);
            }

            

            Console.WriteLine("Press Any Key to Continue ...");
            Console.ReadKey();
        }

        static void FormatTime(TimeSpan ts)
        {
            Console.WriteLine($"\nRunTime: {ts.TotalMilliseconds} milliseconds");
        }
    }
}
