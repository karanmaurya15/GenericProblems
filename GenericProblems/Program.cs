namespace GenericProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to Generics Program\n");
            float output = MaxValue.MaxFloatNumber(3.333f, 2.22f, 1.1f);
            Console.WriteLine("Max Float number is: " + output);
        }
    }
}