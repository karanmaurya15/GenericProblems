namespace GenericProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to Generics Program\n");
            int output = MaxValue.MaxIntegerNumber(11, 3333, 222);
            Console.WriteLine("Max integer number is: " + output);
        }
    }
}