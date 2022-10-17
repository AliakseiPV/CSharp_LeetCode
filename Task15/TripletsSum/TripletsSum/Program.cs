using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripletsSum
{
    internal class Program
    {

        public static IList<IList<int>> ThreeSum(int[] nums)
        {            
            IList<IList<int>> result = new List<IList<int>>();

            if (nums.Length <= 2)
                return result;

            int count = 0;

            for (int i = 0; i < nums.Length - 2; i++)
            {
                for (int j = i + 1; j < nums.Length - 1; j++)
                {
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        if(nums[i] + nums[j] + nums[k] == 0)
                        {
                            List<int> solution = new List<int> {nums[i], nums[j], nums[k]};
                            solution.Sort();
                            foreach (var item in result)
                            {
                                if(item.SequenceEqual(solution))
                                {
                                    count++;
                                    break;
                                }
                            }
                            if (count == 0)
                                result.Add(solution);
                            else count = 0;
                        }
                    }
                }
            }           
            return result;
        }

        static void Main(string[] args)
        {
            int[] nums = { -1, 0, 1, 2, -1, -4 };
            Console.WriteLine(ThreeSum(nums));
    }
    }
}
