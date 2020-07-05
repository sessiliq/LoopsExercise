namespace Histogram
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            double countNumbers = double.Parse(Console.ReadLine());

            int numbersLessThan200 = 0;
            int numbersLessThan400 = 0;
            int numbersLessThan600 = 0;
            int numbersLessThan800 = 0;
            int numbersMoreThan800 = 0;

            for (int i = 0; i < countNumbers; i++)
            {
                int numbers = int.Parse(Console.ReadLine());

                if (numbers < 200)
                {
                    numbersLessThan200++;
                }
                else if (numbers < 400)
                {
                    numbersLessThan400++;
                }
                else if (numbers < 600)
                {
                    numbersLessThan600++;
                }
                else if (numbers < 800)
                {
                    numbersLessThan800++;
                }
                else
                {
                    numbersMoreThan800++;
                }
            }

            double percentLessThan200 = numbersLessThan200 / countNumbers * 100.0;
            double percentLessThan400 = numbersLessThan400 / countNumbers * 100.0;
            double percentLessThan600 = numbersLessThan600 / countNumbers * 100.0;
            double percentLessThan800 = numbersLessThan800 / countNumbers * 100.0;
            double percentMoreThan800 = numbersMoreThan800 / countNumbers * 100.0;

            Console.WriteLine($"{percentLessThan200:F2}%");
            Console.WriteLine($"{percentLessThan400:F2}%");
            Console.WriteLine($"{percentLessThan600:F2}%");
            Console.WriteLine($"{percentLessThan800:F2}%");
            Console.WriteLine($"{percentMoreThan800:F2}%");

        }
    }
}
