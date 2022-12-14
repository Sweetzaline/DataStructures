using System;
using System.IO;
namespace Q3
{
    class BalancedParentheses
    {
        public bool isBalancedParentheses(string filePath)
        {
            string[] listofChars = File.ReadAllText(filePath).Split(" ");
            if (listofChars[0] == ")")
            {
                Console.WriteLine("Given equation is of unbalnced parentheses.");
                return false;
            }
            MyStack<string> stack = new MyStack<string>();
            foreach (string cha in listofChars)
            {
                if (cha == "(")
                {
                    stack.Push(cha);
                }
                if (stack.top == null && cha == ")")
                {
                    Console.WriteLine("Given equation is of unbalnced parentheses.");
                    return false;
                }
                if (cha == ")")
                {
                    stack.Pop();
                }
            }
            if (stack.isEmpty())
            {
                Console.WriteLine("Given equation is of balanecd parentheses.");
            }
            else
            {
                Console.WriteLine("Given equation is of unbalnced parentheses.");
            }
            return stack.isEmpty();
        }
    }
}