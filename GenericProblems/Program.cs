using System.IO;
using System;

namespace GenericProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to Generics Program");

            MaxValue<int> maxValueint = new MaxValue<int>(11, 222, 3333);
            int output1 = maxValueint.MaxMethod();
            Console.WriteLine("\nMax integer number is: " + output1);

            MaxValue<float> maxValuefloat = new MaxValue<float>(1.1f, 2.22f, 3.333f);
            float output2 = maxValuefloat.MaxMethod();
            Console.WriteLine("\nMax float number is: " + output2);

            MaxValue<string> maxValuestring = new MaxValue<string>("Apple", "Peach", "Banana");
            string output3 = maxValuestring.MaxMethod();
            Console.WriteLine("\nMax String is: " + output3);
        }
    }
}