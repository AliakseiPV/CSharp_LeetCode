using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleSumClosest
{
    internal class Program
    {
        public static int ThreeSumClosest(int[] nums, int target)
        {
            int biggerClosest = int.MaxValue;
            int smallerClosest = int.MinValue;

            for (int i = 0; i < nums.Length - 2; i++)
            {
                for (int j = i + 1; j < nums.Length - 1; j++)
                {
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        int tripleSum = nums[i] + nums[j] + nums[k];

                        if (tripleSum == target)
                            return tripleSum;
                        else if (tripleSum > target && tripleSum < biggerClosest)
                            biggerClosest = tripleSum;
                        else if(tripleSum < target && tripleSum > smallerClosest)
                            smallerClosest = tripleSum;
                    }
                }
            }

            if(biggerClosest - target < target - smallerClosest || smallerClosest == int.MinValue)
                return biggerClosest;
            else return smallerClosest;
        }

        static void Main(string[] args)
        {
            int[] nums = {0,1,2};
            int target = 1;
            Console.WriteLine(ThreeSumClosest(nums,target));
        }
    }
}
