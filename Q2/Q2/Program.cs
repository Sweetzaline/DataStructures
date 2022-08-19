using System;
namespace Q2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string inputFilePath = @"C:\Users\Amit Pegu\Desktop\DataStructures\Q2\InputFile.txt";
            string outputFilePath = @"C:\Users\Amit Pegu\Desktop\DataStructures\Q2\OutputFile.txt";
            bool isRun = true;
            while (isRun)
            {
                Console.WriteLine("Select and enter program number:" +
                    "2. Ordered List");
                int programOption = Convert.ToInt32(Console.ReadLine());
                switch (programOption)
                {
                    case 2:
                        new OderedList().OrderedListOperations(inputFilePath, outputFilePath);
                        break;
                    default:
                        isRun = !isRun;
                        break;
                }
            }

        }
    }
}