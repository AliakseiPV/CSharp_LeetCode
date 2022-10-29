using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicates
{
    internal class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {            
            int temp = nums[0];
            int count = 0;

            for (int i = 1, j = 1; i < nums.Length; i++)
            {
                if (nums[i] != temp)
                {
                    temp = nums[i];
                    nums[j] = nums[i];
                    j = i;
                    count++;
                }
            }

            return count;
        }
    }
}
