using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstNames = new string[10];
            //firstNames[0] = "Jacob";
            //firstNames[1] = "Danny";
            int[] numbers = new int[10];
            int i;
            for (i = 0; i < 10; i++)
            {
                numbers[i] = i + 1;
                Console.WriteLine(numbers[i]);
            }
            // Console.WriteLine(firstNames[0]);
            double[] decimalNumbers = new double[3] { 34, 55, 77 }; // [3] is size of array not index
            float[] floatNumbers = { 34.6f, 34.5f };
            floatNumbers[1] = 56.5f;
            Console.WriteLine(floatNumbers[0]);
            Console.WriteLine(decimalNumbers[2]);
            decimalNumbers[2] = 78;
            Console.WriteLine(decimalNumbers[2]);
            Console.ReadKey();
            
        }
    }
}
