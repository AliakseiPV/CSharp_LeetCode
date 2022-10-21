using System;


namespace FourSum
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int[] nums = { 1, 0, -1, 0, -2, 2, 3, 4, -3, 2, -5 };
            var target = 0;

            FourSum fourSum = new FourSum();
            fourSum.SumOfFours(nums, target);
        }
    }
}
