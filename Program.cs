using static NumberCollection.NumberColl;

namespace NumberCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            AverageCalculator averageCalculator = new AverageCalculator(numbers);
            double average = averageCalculator.CalculateAverage();

            SumCalculator sumCalculator = new SumCalculator(numbers);
            int sum = sumCalculator.CalculateSum();

            MaxCalculator maxCalculator = new MaxCalculator(numbers);
            int max = maxCalculator.FindMax();

            MinCalculator minCalculator = new MinCalculator(numbers);
            int min = minCalculator.FindMin();

            NumberColl numberColl = new NumberColl(numbers);
            bool containsThree = numberColl.Contains(3);
            bool containsTen = numberColl.Contaions(10);
            int count = numberColl.Count();

            for (int i = 0; i < count; i++) Console.Write(numbers[i] + " ");

            Console.WriteLine($"\n\nСреднее арифметическое: {average}");
            Console.WriteLine($"Сумма: {sum}");
            Console.WriteLine($"Максимальное число коллекции: {max}");
            Console.WriteLine($"Минимальное: {min}");
            Console.WriteLine($"Содержится ли число 3 в коллекции: {containsThree}");
            Console.WriteLine($"Содержится ли число 10 в коллекции: {containsTen}");
            Console.WriteLine($"Количество элементов в коллекции: {count}");

            Console.ReadKey();
        }
    }
}

