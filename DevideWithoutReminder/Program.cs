namespace DevideWithoutReminder
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            double countNumbers = double.Parse(Console.ReadLine());

            int numbersWithoutReminder2 = 0;
            int numbersWithoutReminder3 = 0;
            int numbersWithoutReminder4 = 0;

            for (int i = 0; i < countNumbers; i++)
            {
                int numbers = int.Parse(Console.ReadLine());

                if (numbers % 2 == 0)
                {
                    numbersWithoutReminder2++;
                }
                if (numbers % 3 == 0)
                {
                    numbersWithoutReminder3++;
                }
                if (numbers % 4 == 0)
                {
                    numbersWithoutReminder4++;
                }
            }

            double percentWithoutReminder2 = numbersWithoutReminder2 / countNumbers * 100.0;
            double percentWithoutReminder3 = numbersWithoutReminder3 / countNumbers * 100.0;
            double percentWithoutReminder4 = numbersWithoutReminder4 / countNumbers * 100.0;

            Console.WriteLine($"{percentWithoutReminder2:F2}%");
            Console.WriteLine($"{percentWithoutReminder3:F2}%");
            Console.WriteLine($"{percentWithoutReminder4:F2}%");
        }
    }
}
