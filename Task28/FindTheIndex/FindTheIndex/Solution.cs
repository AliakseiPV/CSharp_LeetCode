using System;

namespace FindTheIndex
{
    public class Solution
    {
        public int StrStr2(string haystack, string needle)
        {
            return haystack.IndexOf(needle);
        }
        public int StrStr(string haystack, string needle)
        {           
            int result = -1;

            if(haystack.Length < needle.Length)
                return result;

            string temp = string.Empty;
            int index = 0;

            while (index < haystack.Length)
            {
                int j = 0;
                for (int i = index; i < haystack.Length; i++)
                {
                    if (haystack[i] == needle[j])
                    {
                        temp += needle[j];
                        if (temp.Equals(needle))
                        {
                            result = i - (needle.Length - 1);
                            return result;
                        }
                        j++;
                    }
                    else break;

                }
                temp = string.Empty;
                index++;
            }
            
            return result;
        }
    }
}
