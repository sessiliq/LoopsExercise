namespace HalfSumElement
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int countNumbers = int.Parse(Console.ReadLine());
            int sumNumbers = 0;
            int max = int.MinValue;

            for (int i = 0; i < countNumbers; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                sumNumbers += numbers;

                if (numbers > max)
                {
                    max = numbers;
                }
            }

            sumNumbers -= max;

            if (sumNumbers == max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sumNumbers}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(max - sumNumbers)}");
            }
        }
    }
}
