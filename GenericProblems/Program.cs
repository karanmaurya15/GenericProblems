namespace GenericProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to Generics Program\n");
            float output = MaxValue.MaxFloatNumber(1.1f, 2.22f, 3.333f);
            Console.WriteLine("Max integer number is: " + output);
        }
    }
}