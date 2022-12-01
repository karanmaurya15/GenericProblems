
namespace GenericProblems
{
    internal class MaxValue<T> where T : IComparable
    {
        public T Value1, Value2, Value3;
        public MaxValue(T value1, T value2, T value3)
        {
            this.Value1 = value1;
            this.Value2 = value2;
            this.Value3 = value3;
        }
        public static T MaxValueCheck(T value1, T value2, T value3)
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
            return default;
        }
        public T MaxMethod()
        {
            T max = MaxValue<T>.MaxValueCheck(this.Value1, this.Value2, this.Value3);
            return max;
        }
    }
}
