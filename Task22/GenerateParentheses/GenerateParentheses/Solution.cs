using System;
using System.Collections.Generic;

namespace GenerateParentheses
{
    public class Solution
    {
        public IList<string> GenerateParenthesis(int n)
        {
            IList<string> result = new List<string>();
            GenerateBrackets(new char[n*2], 0, result);
            return result;
        }

        private void GenerateBrackets(char[] array, int indexPos, IList<string> result)
        {
            if(indexPos == array.Length)
            {
                if(ValidParanthesis(array))
                    result.Add(String.Join("",array));
            }else
            {
                array[indexPos] = '(';
                GenerateBrackets(array, indexPos + 1, result);
                array[indexPos] = ')';
                GenerateBrackets(array, indexPos + 1, result);
            }
        }

        private bool ValidParanthesis(char[] array)
        {
            int index = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] == '(')
                    index++;
                else
                    index--;
                if (index < 0)
                    return false;
            }
    
            return index == 0;
        }

        public void PrintCombinations(int n)
        {
            var combinations = GenerateParenthesis(n);

            Console.WriteLine($"Number of combinations: {combinations.Count}");
            Console.WriteLine(String.Join("\n",combinations));
        }
    }
}
