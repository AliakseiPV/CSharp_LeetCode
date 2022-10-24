using System;


namespace ValidParentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p = new Parentheses();

            Console.WriteLine(p.IsValid("({[]})"));
            Console.WriteLine(p.IsValid("({[()]})"));
            Console.WriteLine(p.IsValid("(([]})"));
            Console.WriteLine(p.IsValid("()[]{}"));
        }
    }
}
