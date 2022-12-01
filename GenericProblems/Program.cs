using System.IO;
using System;

namespace GenericProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to Generics Program\n");
            string output = MaxValue.MaxString("Peach", "Apple", "Banana");
            Console.WriteLine("Max String is: " + output);
        }
    }
}