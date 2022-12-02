using System.IO;
using System;

namespace GenericProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to Generics Program");

            MaxValue<int> maxValueint = new MaxValue<int>(11, 222, 3333, 4444);
            int output1 = maxValueint.MaxMethod();
            Console.WriteLine("\nMax integer number is : " + output1 );

            MaxValue<float> maxValueFloat = new MaxValue<float>(1.1f, 22.2f, 3.333f, 44.44f);
            float output2 = maxValueFloat.MaxMethod();
            Console.WriteLine("\nMax integer number is : " + output2);

            MaxValue<string> maxValueString = new MaxValue<string>("Apple", "Peach", "Banana", "Pineapple");
            string output3 = maxValueString.MaxMethod();
            Console.WriteLine("\nMax integer number is : " + output3);


            Console.WriteLine("\n~~~~~Finding Max value~~~~~");
            int[] array = { 14, 564, 733, 448, 678 };
            MaxValue<int> maxValue = new MaxValue<int>(array);
            maxValue.PrintMaxValue();
        }
    }
}