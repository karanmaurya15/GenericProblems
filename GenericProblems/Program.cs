﻿namespace GenericProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to Generics Program\n");
            int output = MaxValue.MaxIntegerNumber(222, 3333, 11);
            Console.WriteLine("Max integer number is: " + output);
        }
    }
}