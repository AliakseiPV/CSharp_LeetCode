using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static bool IsPalindrome(int x)
        {
            string input = Convert.ToString(x);
            string output = string.Empty;

            if (input[0] == '-')
                return false;

            for (int i = 0; x >= 1; i++)
            {
                output += Convert.ToString(x % 10);
                x = x / 10;
            }

            if(input.Length == 1 || input == output)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            int number = 121;
            Console.WriteLine(IsPalindrome(number));
            Console.ReadLine();
        }
    }
}
