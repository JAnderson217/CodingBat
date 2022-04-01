using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmup_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"sleepIn test with weekday,vacation: false,false = {sleepIn(false, false)}, true,false = {sleepIn(true, false)}, false,true = {sleepIn(false, true)}");
            Console.WriteLine($"backAround test with cat, Hello, a: {backAround("cat")}, {backAround("Hello")}, {backAround("a")}");
            Console.WriteLine($"nearHundred test with 93,89,194: {nearHundred(93)}, {nearHundred(89)}, {nearHundred(194)}");
            Console.WriteLine($"mixStart test with: mix snacks = {mixStart("mix snacks")}, pix snacks = {mixStart("pix snacks")}, piz snacks = {mixStart("piz snacks")}");
            Console.WriteLine($"sumDouble test with (1,2), (3,2), (2,2): {sumDouble(1,2)}, {sumDouble(3, 2)}, {sumDouble(2, 2)}");
            Console.WriteLine($"lastDigit test with (7,17), (6,17), (3,113): {lastDigit(7, 17)}, {lastDigit(6, 17)}, {lastDigit(3, 113)}");
            Console.WriteLine($"everyNth test with (Miracle,2), (abcdefg,2), (abcdefg,3): {everyNth("Miracle", 2)}, {everyNth("abcdefg", 2)}, {everyNth("abcdefg", 3)}");
            Console.ReadLine();
        }

        public static bool sleepIn(bool weekday, bool vacation)
        {
            //sleep in if not weekday or vacation
            if (!weekday || vacation)
            {
                return true;
            }
            return false;
        }
        public static string backAround(String str)
        {
            char c = str[str.Length - 1];
            str = c + str + c;
            return str;
        }
        public static bool nearHundred(int n)
        {
            //Return true if number is within 10 of 100 or 200
            if (n >= 90 && n <= 110)
            {
                return true;
            }
            if (n >= 190 && n <= 210)
            {
                return true;
            }
            return false;
        }
        public static bool mixStart(String str)
        {
            string test = str.Substring(1, 2);
            if (test.Equals("ix"))
            {
                return true;
            }
            return false;
        }
        public static int sumDouble(int a, int b)
        {
            if (a == b)
            {
                return (a + b) * 2;
            }
            return a + b;
        }
        public static bool lastDigit(int a, int b)
        {
            if (a %10 == b% 10)
            {
                return true;
            }
            return false;
        }
        public static string everyNth(string str, int a)
        {
            char[] chars = str.ToCharArray();
            string newStr = "";
            for (int i = 0; i < chars.Length; i=i+a)
            {
                newStr += chars[i];
            }
            return newStr;
        }
    }
}
