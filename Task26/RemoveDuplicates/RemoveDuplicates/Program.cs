using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[] {0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            var result = new Solution();

            Console.WriteLine(result.RemoveDuplicates(input));
            Console.ReadLine();
        }
    }
}
