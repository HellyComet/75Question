using System;
using System.Text;

namespace MergeStringsAlternately
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word1 = "abc";
            string word2 = "pqr";

            string result = MergeAlternately(word1, word2);

            Console.WriteLine(result);
            Console.ReadLine();
        }
        public static string MergeAlternately(string word1, string word2)
        {
            StringBuilder result = new StringBuilder();

            int word1Increment = 0;
            int word2Increment = 0;

            while (word1Increment < word1.Length && word2Increment < word2.Length)
            {

                result.Append(word1[word1Increment]).Append(word2[word2Increment]);

                word1Increment++;
                word2Increment++;
            }

            while(word1Increment < word1.Length)
            {
                result.Append(word1[word1Increment]);
                word1Increment++;
            }
            while(word2Increment < word2.Length)
            {
                result.Append(word2[word2Increment]);
                word2Increment++;
            }

            return result.ToString();
        }
    }
}
