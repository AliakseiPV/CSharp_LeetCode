using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerWithMostWater
{
    internal class Program
    {
        public static int MaxArea(int[] height)
        {
            int maxAmount = int.MinValue;
            int amountOfWater;

            for (int i = 0; i < height.Length; i++)
            {
                for (int j = i + 1; j < height.Length; j++)
                {
                    if (height[i] <= height[j])
                        amountOfWater = height[i] * (j - i);
                    else
                        amountOfWater = height[j] * (j - i);

                    if (maxAmount < amountOfWater)
                        maxAmount = amountOfWater;
                }
            }
            return maxAmount;
        }

        static void Main(string[] args)
        {
            int[] numbers = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            Console.WriteLine(MaxArea(numbers));
            Console.ReadLine();
        }
    }
}
