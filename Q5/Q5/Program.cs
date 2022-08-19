using System;
namespace Q5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool isRun = true;
            while (isRun)
            {
                Console.WriteLine("\nSelect and enter program number:" +
                    "(5. Palindrome check by deque)");
                int programOption = Convert.ToInt32(Console.ReadLine());
                switch (programOption)
                {
                   case 5:
                        new PalindromCheckByDeque().isPalindrome();
                        break;
                    default:
                        isRun = !isRun;
                        break;
                }
            }

        }
    }
}