using System;
using System.IO;
namespace Q6
{
    public class Program
    {
        public static void Main(string[] args)
        {
           string hashingNumbersFilePath = @"C:\Users\Amit Pegu\Desktop\DataStructures\Q6\HashingInputNumbers.txt";
            bool isRun = true;
            while (isRun)
            {
                Console.WriteLine("\nSelect and enter program number:" +
                    "(6. Hashing function)");
                int programOption = Convert.ToInt32(Console.ReadLine());
                switch (programOption)
                {
                    case 6:
                        int[] numbersList = Array.ConvertAll(File.ReadAllText(hashingNumbersFilePath).Split(","), int.Parse);
                        // Array.Sort(numbersList);
                        new HashingFunction().Hashing(numbersList);
                        break;
                    default:
                        isRun = !isRun;
                        break;
                }
            }

        }
    }
}