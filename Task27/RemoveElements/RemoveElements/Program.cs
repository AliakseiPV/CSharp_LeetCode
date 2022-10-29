using System;

namespace RemoveElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.RemoveElement(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2);
        }
    }
}
