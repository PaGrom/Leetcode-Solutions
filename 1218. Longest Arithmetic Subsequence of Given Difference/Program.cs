using System;
using System.Collections.Generic;

namespace _1218._Longest_Arithmetic_Subsequence_of_Given_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(LongestSubsequence(new int[] { 1,2,3,4 }, 1));
            //Console.WriteLine(LongestSubsequence(new int[] { 1, 3, 5, 7 }, 1));
            Console.WriteLine(LongestSubsequence(new int[] { 1, 5, 7, 8, 5, 3, 4, 2, 1 }, -2));
        }

        public static int LongestSubsequence(int[] arr, int difference)
        {
            var biggestLength = 1;

            var n = arr.Length;

            var indexes = new int[n];

            var length = new int[n];

            var lastGoodIndex = 0;

            for(var i = 0; i < n; i++)
            {
                length[i] = 1;

                if (i == 0)
                {
                    indexes[i] = -1;
                    
                    continue;
                }

                int goodIndex = -1;

                for(int j = 0; j < i; j++)
                {
                    if (arr[j] + difference == arr[i])
                    {
                        if (goodIndex == -1)
                        {
                            goodIndex = j;
                            continue;
                        }
                        
                        if (length[j] > length[goodIndex])
                        {
                            goodIndex = j;
                        }
                    }
                }

                indexes[i] = goodIndex;
                if (goodIndex > -1)
                {
                    length[i] = length[goodIndex] + 1;

                    if (biggestLength < length[i])
                    {
                        biggestLength = length[i];
                        lastGoodIndex = goodIndex;
                    }
                }

            }


            return biggestLength;
        }
    }
}
