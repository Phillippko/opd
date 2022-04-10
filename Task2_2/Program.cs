using System;

namespace Task2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int delay;
            Console.WriteLine("Задержка:");
            CentralElectionCommission centralElectionCommission = new CentralElectionCommission();

            centralElectionCommission.subscribe(new HonestObserver("Дождь"));
            centralElectionCommission.subscribe(new DishonestObserver("Царьград"));
            centralElectionCommission.subscribe(new DishonestObserver("РИА новости"));
            centralElectionCommission.subscribe(new HonestObserver("Медуза"));

            while (!int.TryParse(Console.ReadLine(), out delay)){}

            centralElectionCommission.notify(delay, "Всё мирно");
            centralElectionCommission.notify(delay, "Вброс");
            centralElectionCommission.notify(delay, "Вброс");
            centralElectionCommission.notify(delay, "Конец");
            Console.ReadKey();
        }
    }
}
