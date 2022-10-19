using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersCombinations
{
    internal class Program
    {

        public static IList<string> letterCombinations(string digits)
        {

            IList<string> answer = new List<string>();

            if (digits.Length == 0) 
                return answer;

            Dictionary<char, string> dictionary = new Dictionary<char, string>()
            {
                {'2',"abc"},
                {'3',"def"},
                {'4',"ghi"},
                {'5',"jkl"},
                {'6',"mno"},
                {'7',"pqrs"},
                {'8',"tuv"},
                {'9',"wxyz"},
            };
            
            string temp = "";
            int index = 0;

            BackTrack(index, temp, digits, answer, dictionary);
            return answer;
        }

        public static void BackTrack
       (int index, string temp, string digits, IList<string> answer, Dictionary<char,string> dictionary)
        {

            if (index == digits.Length)
            {
                answer.Add(temp);
                return;
            }
            char digit = digits[index];
            string str = dictionary[digit];

            for (int j = 0; j < str.Length; j++)
            {
                char c = str[j];
                temp += c;

                BackTrack(index + 1, temp, digits, answer, dictionary);

                temp = temp.Substring(0, temp.Length - 1);
            }

        }


        static void Main(string[] args)
        {
            var answer = letterCombinations("234");
        }
    }
}
