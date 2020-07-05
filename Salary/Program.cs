namespace Salary
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int countTabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            int fee = 0;

            for (int i = 0; i < countTabs; i++)
            {
                string nameSite = Console.ReadLine();

                if (nameSite == "Facebook")
                {
                    fee += 150;
                }
                else if (nameSite == "Instagram")
                {
                    fee += 100;
                }
                else if (nameSite == "Reddit")
                {
                    fee += 50;
                }

                if (fee >= salary)
                {
                    Console.WriteLine("You have lost your salary.");
                    return;
                }
            }

            Console.WriteLine($"{salary - fee}");
        }
    }
}
