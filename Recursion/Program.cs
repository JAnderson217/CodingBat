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
    }
}
