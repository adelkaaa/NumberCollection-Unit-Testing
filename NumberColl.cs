using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberCollection
{
    public class NumberColl
    {
        private int[] numbers;

        public NumberColl(int[] numbers)
        {
            this.numbers = numbers;
        }

        public double GetAverage()
        {
            return numbers.Average();
        }

        public int GetSum()
        {
            return numbers.Sum();
        }

        public int GetMax()
        {
            return numbers.Max();
        }

        public int GetMin()
        {
            return numbers.Min();
        }

        public bool Contains(int number)
        {
            return numbers.Contains(number);
        }

        public int Count()
        {
            return numbers.Length;
        }
    }
}
