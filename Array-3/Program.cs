using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"fix34 test with 1,3,1,4 - 1,3,1,4,4,3,1 - 3,2,2,4");
            Console.Write(string.Join(",", fix34(new int[] { 1, 3, 1, 4 })) + " - ");
            Console.Write(string.Join(",", fix34(new int[] { 1, 3, 1, 4, 4, 3, 1 })) + " - ");
            Console.WriteLine(string.Join(",", fix34(new int[] { 3, 2, 2, 4 })));
            Console.WriteLine($"canBalance test with 1,1,1,2,1 - 2,1,1,2,1 - 10,10: {canBalance(new int[] {1,1,1,2,1})}, {canBalance(new int[] {2,1,1,2,1})}, {canBalance(new int[] {10,10})}");
            Console.WriteLine($"linearIn test with [1, 2, 4, 6], [2, 4] - [1, 2, 4, 6], [2, 3, 4] - [1, 2, 4, 4, 6], [2, 4]: {linearIn(new int[] {1,2,4,6,}, new int[] {2,4})}, {linearIn(new int[] { 1, 2, 4, 6, }, new int[] { 2,3,4 })}, {linearIn(new int[] { 1, 2, 4,4, 6, }, new int[] { 2, 4 })}");
            Console.Write("squareUp test with 4: ");
            squareUp(4);
            Console.Write("seriesUp test with 5: ");
            seriesUp(5);
            Console.WriteLine($"countClumps test with [1,2,2,3,4,4], [1,1,1,1,1]: {countClumps(new int[] { 1, 2, 2, 3, 4, 4 })}, {countClumps(new int[] {1,1,1,1,1})}");
            Console.ReadLine();
        }

        public static int[] fix34(int[] nums)
        {
            int threeIndex = 0;
            int fourIndex = 4;
            int temp = 0;
            //loop through to find first indexes of three and four
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 3)
                {
                    threeIndex = i;
                    break;
                }
            }
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] == 4)
                {
                    fourIndex = j;
                    break;
                }
            }
            //loop needed to check for multiple instances of 3 and 4
            while (threeIndex < nums.Length)
            {
                if (nums[threeIndex] == 3)
                {
                    temp = nums[threeIndex + 1];
                    nums[threeIndex + 1] = nums[fourIndex];
                    nums[fourIndex] = temp;

                    while (fourIndex < nums.Length && nums[fourIndex] != 4)
                        fourIndex++;
                }
                threeIndex++;
            }
            //Console.WriteLine(string.Join(",", nums));
            return nums;
        }
        public static bool canBalance(int[] nums)
        {
            //loop through array, check if balanced by adding one side and subtracting other
            for (int i=1; i<nums.Length; i++)
            {
                int balance = 0;
                //add left side
                for (int j=0; j<i; j++)
                {
                    balance += nums[j];
                }
                //subtract right side
                for (int k=i; k<nums.Length; k++)
                {
                    balance -= nums[k];
                }
                if (balance == 0) { return true; }
            }
            return false;
        }
        public static bool linearIn(int[] outer, int[] inner)
        {
            if (inner.Length == 0)
            {
                return true;
            }
            int match = 0;
            int innerIndex = 0;
            //loop through check for matches
            for (int i=0; i<outer.Length; i++)
            {
                if (outer[i] == inner[innerIndex])
                {
                    match++;
                    innerIndex++;
                }
                //if total matches = size of inner then true
                if (match == inner.Length) { return true; }
            }
            return false;
        }
        public static int[] squareUp(int n)
        {
            //fill new array with n*n values, with pattern of n, n-1, n-2 etc for top square and n-1, n-2 etc for lower squares etc
            //0,0,0,1 -> 0,0,2,1 -> 0,3,2,1 -> 4,3,2,1
            int[] squared = new int[n*n];
            for (int i = 0; i<n; i++)
            {
                for(int j=0; j<n; j++)
                {
                    //if statement to check if should be filled or left as 0, n-1 gets which square, as each square has n-1, n-2 etc zeros
                    //-1 as not every term is filled with zero
                    if (j <n-i-1)
                    {
                        continue;
                    }
                    //i*n to determine which square, j to determine which term of n, then fill with n-j i.e. n-1, n-2, n-3 etc
                    squared[i*n +j] = n-j;
                }
            }
            foreach(int i in squared)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            return squared;
        }
        public static int[] seriesUp(int n)
        {
            int[] nums = new int[n*(n+1)/2];
            int index = 0;
            //i is row, j is term, fill each row from 1-N, 
            for (int i = 0; i<n; i++)
            {
                for (int j=0; j<1+i; j++)
                {
                    nums[index] = j+1;
                    index++; 
                }
            }
            foreach(var i in nums)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            return nums;
        }
        public static int countClumps(int[] nums)
        {
            int count = 0;
            for (int i=0; i<nums.Length-1; i++)
            {
                //if duplicate pair, then subtract 1 to account for addition
                if (i >= 1 && nums[i-1] == nums[i] && nums[i] == nums[i+1])
                {
                    count--;
                }
                //add to count if matching pair
                if (nums[i] == nums[i + 1])
                {
                    count++;
                }
            }
            return count;
        }
    }
}
