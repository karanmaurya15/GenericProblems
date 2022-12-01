
namespace GenericProblems
{
    internal class MaxValue
    {
        public T MaxValueCheck<T>(T value1, T value2, T value3) where T : IComparable
        {
            if (value1.CompareTo(value2) > 0 && value1.CompareTo(value3) > 0)
            {
                return value1;
            }
            if (value2.CompareTo(value1) > 0 && value2.CompareTo(value3) > 0)
            {
                return value2;
            }
            if (value3.CompareTo(value1) > 0 && value3.CompareTo(value2) > 0)
            {
                return value3;
            }
            throw new Exception("All Strings are same");

        }
    }
}
