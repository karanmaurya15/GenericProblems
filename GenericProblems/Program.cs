namespace GenericProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to Generics Program\n");
            int output = MaxValue.MaxIntegerNumber(11, 222, 3333);
            Console.WriteLine("Max integer number is: " + output);
        }
    }
}