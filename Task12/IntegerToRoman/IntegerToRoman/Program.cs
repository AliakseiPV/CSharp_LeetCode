using System;
using System.Text;

namespace IntegerToRoman
{
    internal class Program
    {
        public static string IntToRoman(int num)
        {
            string[] romans = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < values.Length; i++)
            {
                while (num >= values[i])
                {
                    num -= values[i];
                    stringBuilder.Append(romans[i]);
                }
            }
            return stringBuilder.ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine(IntToRoman(3));
            Console.WriteLine(IntToRoman(109));
            Console.WriteLine(IntToRoman(1998));
        }
    }
}
