using System;
using System.Text;

namespace GreatestCommonDivisorOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "ABCABC";
            string str2 = "ABC";
            string result = GcdOfStrings(str1, str2);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static string GcdOfStrings(string str1, string str2)
        {
            int n1 = str1.Length;
            int n2 = str2.Length;
            if(str1 + str2 != str2 + str1)
            {
                return "";
            }
            return str1.Length > str2.Length ?
                str1.Substring(0,gcd(n1, n2)) : str2.Substring(0, gcd(n2, n1));
        }

        private static int gcd(int a, int b)
        {
            if(b == 0)
                return a;
            return gcd(b, a % b);
        }
    }
}
