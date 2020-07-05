namespace EvenOddPosition
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int countNumbers = int.Parse(Console.ReadLine());

            double evenSum = 0;
            double evenMax = double.MinValue;
            double evenMin = double.MaxValue;

            double oddSum = 0;
            double oddMax = double.MinValue;
            double oddMin = double.MaxValue;

            for (int i = 1; i <= countNumbers; i++)
            {
                double numbers = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += numbers;

                    if (numbers > evenMax)
                    {
                        evenMax = numbers;
                    }
                    if (numbers < evenMin)
                    {
                        evenMin = numbers;
                    }
                }
                else
                {
                    oddSum += numbers;

                    if (numbers > oddMax)
                    {
                        oddMax = numbers;
                    }
                    if (numbers < oddMin)
                    {
                        oddMin = numbers;
                    }
                }
            }

            if (countNumbers == 1)
            {
                Console.WriteLine($"OddSum={oddSum:F2},");
                Console.WriteLine($"OddMin={oddMin:F2},");
                Console.WriteLine($"OddMax={oddMax:F2},");
                Console.WriteLine($"EvenSum=0.00,");
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No");
            }
            else if (countNumbers == 0)
            {
                Console.WriteLine($"OddSum=0.00,");
                Console.WriteLine($"OddMin=No,");
                Console.WriteLine($"OddMax=No,");
                Console.WriteLine($"EvenSum=0.00,");
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No");
            }
            else
            {
                Console.WriteLine($"OddSum={oddSum:F2},");
                Console.WriteLine($"OddMin={oddMin:F2},");
                Console.WriteLine($"OddMax={oddMax:F2},");
                Console.WriteLine($"EvenSum={evenSum:F2},");
                Console.WriteLine($"EvenMin={evenMin:F2},");
                Console.WriteLine($"EvenMax={evenMax:F2}");
            }
        }
    }
}
