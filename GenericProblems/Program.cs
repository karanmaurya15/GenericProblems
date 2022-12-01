using System.IO;
using System;

namespace GenericProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to Generics Program");

            MaxValue maxValue = new MaxValue();
            int output1 = maxValue.MaxValueCheck<int>(11, 222, 3333);
            Console.WriteLine("\nMax integer number is: " + output1);

            float output2 = maxValue.MaxValueCheck<float>(1.1f, 2.22f, 3.333f);
            Console.WriteLine("\nMax float number is: " + output2);

            string output3 = maxValue.MaxValueCheck<string>("Banana", "Apple", "Peach");
            Console.WriteLine("\nMax String is: " + output3);
        }
    }
}