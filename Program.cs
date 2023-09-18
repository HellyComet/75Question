using System;
//Time complexity : O(n)
//Space complexity : O(1)

namespace FlowerBed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] flowerbed = { 1, 0, 0, 0, 1 };
            int n = 1;
            bool canplace = CanPlaceFlowers(flowerbed, n);
            Console.WriteLine("Can Place Flowers" + " " + canplace);
        }
        public static bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            int numOfPlaceableBeds = 0;
            for (int i = 0; i< flowerbed.Length; i++)
            {
                if(( i==0 || flowerbed[i-1] ==0) && 
                    flowerbed[i] == 0 && 
                    (i == flowerbed.Length - 1 || flowerbed[i+1] == 0))
                {
                    flowerbed[i] = 1;
                    numOfPlaceableBeds++;
                }
            }
            return numOfPlaceableBeds >= n;       
        }
    }
}
