using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberCollection
{
    private int[] numbers;

    public class AverageCalculator
    {
        public AverageCalculator(int[] numbers)
        {
            this.numbers = numbers;
        }

        public double CalculateAverage()
        {
            return numbers.Average();
        }
    }

    public class SumCalculator
    {

        public SumCalculator(int[] numbers)
        {
            this.numbers = numbers;
        }

        public int CalculateSum()
        {
            return numbers.Sum();
        }
    }

    public class MaxCalculator
    {
        public MaxCalculator(int[] numbers)
        {
            this.numbers = numbers;
        }

        public int FindMax()
        {
            return numbers.Max();
        }
    }

    public class MinCalculator
    {

        public MinCalculator(int[] numbers)
        {
            this.numbers = numbers;
        }

        public int FindMin()
        {
            return numbers.Min();
        }
    }

    public class NumberColl
    {
        public NumberColl(int[] numbers)
        {
            this.numbers = numbers;
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
