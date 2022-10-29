using System;

namespace RemoveElements
{
    internal class Solution
    {
        public int RemoveElement(int[] nums, int val)
        {
            int j = nums.Length - 1;

            for (int i = 0; i <= j; i++)
            {

                if (nums[i] == val && nums[j] != val)
                {
                    nums[i] = nums[j];
                    j--;
                }
                else if (nums[i] == val && nums[j] == val)
                {
                    j--;
                    i--;
                }
            }
            return j + 1;
        }
    }
}
