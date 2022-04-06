using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"factorial test with 2,3,6: {factorial(2)}, {factorial(3)}, {factorial(6)}");
            Console.WriteLine($"countX test with xxhixx, xhixhix, x {countX("xxhixx")}, {countX("xhixhix")}, {countX("x")}");
            Console.WriteLine($"splitArray test with [2,2], [2,3], [5,2,3] {splitArray(new int[] { 2, 2 })}, {splitArray(new int[] { 2, 3 })}, {splitArray(new int[] { 5, 2, 3 })}");
            Console.ReadLine();
        }
        static int factorial(int n)
        {
            if (n == 1) return 1;
            //will keep running through until 1 is returned, will then backtrack
            return n * factorial(n - 1);
        }

        public static int countX(String str)
        {
            int count = 0;
            if (str.Length == 0)
            {
                return 0;
            }
            //count if x
            if (str[0] == 'x')
                count++;
            //remove first char and rerun until length is 0
            str = str.Substring(1);
            return count + countX(str);
        }
        public static bool splitArray(int[] nums)
        {
            //return index, sum of left side, sum of right side, numbs - initially set to zero
            return splitArrayHelper(0,0,0,nums);
        }
        public static bool splitArrayHelper(int i, int l, int r, int[] nums)
        {
            //check to end recursion, both sides have to be equal
            if (i >= nums.Length)
            {
                return l == r;
            }
            //continue recursion, could be added to left or right side, so use or to check both instances, add 1 to index
            return splitArrayHelper(i+1, l + nums[i], r, nums) || splitArrayHelper(i+1, l, r + nums[i], nums);
/*            if (splitarrayhelper(i+1, l + nums[i], r, nums))
            {
                return true;
            }
            if (splitarrayhelper(i+1, l, r + nums[i], nums))
            {
                return true;
            }
            return false; */  
        }   
    }
}
