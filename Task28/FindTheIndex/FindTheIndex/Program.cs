using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheIndex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.StrStr2("sadbutsad", "sad"));
            Console.WriteLine(solution.StrStr2("leetcode", "leeto"));
            Console.WriteLine(solution.StrStr2("mississippi", "issip"));
            Console.WriteLine(solution.StrStr2("aabaabbbaabbbbabaaab", "abaa"));
            

        }
    }
}
