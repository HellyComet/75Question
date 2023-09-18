﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace KidsWithGreatestNumberofCandies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] candies = { 2, 3, 5, 1, 3 };
            int extraCandies = 3;
            IList<bool> kids = new List<bool>();
            kids = KidsWithCandies(candies, extraCandies);
            Console.Write(kids);
        }

        public static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
           /* int max = 0;


            for (int i = 0; i < candies.Length; i++)
            {
                if(max < candies[i])
                {
                    max = candies[i];
                }
            }

            bool[] result = new bool[candies.Length];

            for(int i = 0; i < candies.Length;i++)
            {
                if(candies[i] + extraCandies >= max)
                {
                    result[i] = true;
                }
            }
            return result.ToList();
           */

            return candies.Select(x => x + extraCandies >= candies.Max()).ToArray();
            
        }
    }
}
