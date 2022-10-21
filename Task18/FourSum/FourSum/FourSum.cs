using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourSum
{
    internal class FourSum
    {
        public IList<IList<int>> SumOfFours(int[] nums, int target)
        {
            IList<IList<int>> result = new List<IList<int>>();

            if (nums.Length < 4)
                return result;

            Array.Sort(nums);
            int count = 0;

            for (int i = 0; i < nums.Length - 3; i++)
            {
                for (int j = i + 1; j < nums.Length - 2; j++)
                {
                    int left = j + 1;
                    int right = nums.Length - 1;

                    while (left < right)
                    {
                        long sum = (long)(nums[i] + nums[j]) + (long)(nums[left] + nums[right]);

                        if (sum == target)
                        {
                            List<int> solution = new List<int> { nums[i], nums[j], nums[left], nums[right] };
                            foreach (var item in result)
                            {
                                if (item.SequenceEqual(solution))
                                {
                                    count++;
                                    break;
                                }
                            }
                            if (count == 0)
                                result.Add(solution);
                            else count = 0;
                            left++;
                            right--;
                        }
                        else if (sum < target)
                            left++;
                        else                        
                            right--;                        
                    }
                }
            }
            return result;
        }
    }
}
