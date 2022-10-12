using System;
using System.Diagnostics;


namespace LongestCommonPrefix
{
    internal class Program
    {
        public static string LongestCommonPrefix(string[] strs)
        {
            string prefix = string.Empty;           
            char letter;

            Array.Sort(strs);
            
            for (int i = 0; i < strs[0].Length; i++)
            {
                letter = (strs[0])[i];
               
                for (int j = 0; j < strs.Length; j++)
                {
                    if (letter != (strs[j])[i])
                    {
                        return prefix;
                    }                        
                }
                prefix += letter;
            }
            return prefix;
        }

        static void Main(string[] args)
        {                        
            string[] strs = { "flower", "flow", "flowht" };            
            Console.WriteLine(LongestCommonPrefix(strs));                        
        }
    }
}
