using System;

namespace LeetCode08
{
    internal class Program
    {

        public static int MyAtoi(string s)
        {
            string number = string.Empty;
            double result;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != '-' && s[i] != '+' && !char.IsDigit(s[i]) && !char.IsWhiteSpace(s[i]))
                    break;
                if (s[i] == '+' || s[i] == '-' || char.IsDigit(s[i]))
                {
                    number += s[i];
                    if (i + 1 == s.Length || !char.IsDigit(s[i + 1]))
                        break;
                }
            }
            try
            { result = Convert.ToDouble(number); }
            catch (Exception)
            { result = 0; }

            if (result > int.MaxValue)
                return int.MaxValue;
            else if (result < int.MinValue)
                return int.MinValue;
            else return (int)result;
        }


        static void Main(string[] args)
        {
            string s = "   -115579378e25";
            Console.WriteLine(MyAtoi(s));
            Console.ReadLine();
        }
    }
}
