namespace GenericProblems
{
    internal class MaxValue<T> where T : IComparable
    {
        public T value1, value2, value3, value4;

        public MaxValue(T value1, T value2, T value3, T value4)
        {
            this.value1 = value1;
            this.value2 = value2;
            this.value3 = value3;
            this.value4 = value4;
        }

        public static T MaxNumber(T value1, T value2, T value3, T value4)
        {
            if (value1.CompareTo(value2) > 0 && value1.CompareTo(value3) > 0 && value1.CompareTo(value4) > 0)
            {
                return value1;
            }
            if (value2.CompareTo(value1) > 0 && value2.CompareTo(value3) > 0 && value2.CompareTo(value4) > 0)
            {
                return value2;
            }
            if (value3.CompareTo(value1) > 0 && value3.CompareTo(value2) > 0 && value3.CompareTo(value4) > 0)
            {
                return value3;
            }
            if (value4.CompareTo(value1) > 0 && value4.CompareTo(value2) > 0 && value4.CompareTo(value3) > 0)
            {
                return value4;
            }
            return default;
        }

        public T MaxMethod()
        {
            T max = MaxValue<T>.MaxNumber(this.value1, this.value2, this.value3, this.value4);
            return max;
        }
        // Using Sorting
        public T[] values;
        public MaxValue(T[] values)
        {
            this.values = values;
            
        }
        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }
       
    }
}
