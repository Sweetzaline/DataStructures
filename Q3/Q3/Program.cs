using System;
namespace Q3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string equationFilePath = @"C:\Users\Amit Pegu\Desktop\DataStructures\Q3\equationFile.txt";
            bool isRun = true;
            while (isRun)
            {
                Console.WriteLine("Select and enter program number:" +
                    "(1. Unordered List, 2. Ordered List, 3. Balanced Parentheses");
                int programOption = Convert.ToInt32(Console.ReadLine());
                switch (programOption)
                {
                    case 3:
                        new BalancedParentheses().isBalancedParentheses(equationFilePath);
                        break;
                    default:
                        isRun = !isRun;
                        break;
                }
            }

        }
    }
}