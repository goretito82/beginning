using System;
using System.Collections.Generic;
using System.Linq;
namespace exercise_76
{
    class Program
    {

        public static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            int result = Sum(numbers);
            Console.WriteLine("{0}", Convert.ToString(result));
        }


        public static int Sum(List<int> numbers)
        {

            numbers.Add(3);
            numbers.Add(2);
            numbers.Add(6);
            numbers.Add(-1);
            numbers.Add(5);
            numbers.Add(1);
            return numbers.Sum();
        }

    }
}
