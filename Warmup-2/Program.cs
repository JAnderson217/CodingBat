﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmup_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"stringTiems test with (Hi,2), (Test,3), (Hi,1): {stringTimes("Hi", 2)}, {stringTimes("Test", 3)}, {stringTimes("Hi", 1)}");
            Console.WriteLine($"frontTimes test with (Chocolate,2), (Chocolate,3), (Abc,3): {frontTimes("Chocolate", 2)}, {frontTimes("Chocolate", 3)}, {frontTimes("Abc", 3)}");
            Console.WriteLine($"countXX test with abcxx, xxx, xxxx: {countXX("abcxx")}, {countXX("xxx")}, {countXX("xxxx")}");
            Console.ReadLine();
        }

        public static string stringTimes(String str, int n)
        {
            string newStr = "";
            for (int i=0; i<n; i++)
            {
                newStr += str;
            }
            return newStr;
        }
        public static string frontTimes(String str, int n)
        {
            str = str.Substring(0, 3);
            string newStr = "";
            for (int i = 0; i < n; i++)
            {
                newStr += str;
            }
            return newStr;
        }
        public static int countXX(String str)
        {
            char[] chars = str.ToCharArray();
            int count = 0;
            for (int i = 0; i < chars.Length-1; i++)
            {
                if (chars[i].Equals(chars[i+1]))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
