using System;
using System.Collections.Generic;
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
            // Turn to a list if I have to
            string[] words = File.ReadAllLines(textFile);

            //// Sort list from Z-A
            //for (int i = words.Length-1; i > -1; i--)
            //{
            //    Console.WriteLine(words[i]);
            //}

            // Return all words starting with 'Z'
            var queryResults =
                from n in words
                where n.StartsWith("Z")
                select n;
            Console.WriteLine(queryResults);

            // Return all words that start with 'He'

            // Return all words that the second letter is an 'e'

            Console.WriteLine("Press Any Key to Continue ...");
            Console.ReadKey();
        }
    }
}
