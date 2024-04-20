using static NumberCollection.NumberColl;

namespace NumberCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            NumberColl numberCollection = new NumberColl(numbers);

            double average = numberCollection.GetAverage();
            int sum = numberCollection.GetSum();
            int max = numberCollection.GetMax();
            int min = numberCollection.GetMin();
            bool containsThree = numberCollection.Contains(3);
            bool containsTen = numberCollection.Contains(10);
            int count = numberCollection.Count();

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

