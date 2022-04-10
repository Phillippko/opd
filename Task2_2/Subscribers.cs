using System;

    public abstract class Observer
    {
    public readonly string name;

    public Observer(string name)
    {
        this.name = name;
    }
    public abstract void display(string message);
    }

    public class HonestObserver : Observer
    {
    public HonestObserver(string name) : base(name)
    {
    }

    public override void display(string message) {
            {
                if (message.Equals("Вброс"))
                    Console.WriteLine(name + ": Замечен вброс!!!");
                else if (message.Equals("Всё мирно"))
                    Console.WriteLine(name + ": Вбросы происходят незаметно");
                else
                    Console.WriteLine(name + ": Навальный победил! Выходим на улицы");
            }
        }

    }
        public class DishonestObserver : Observer
    {
    public DishonestObserver(string name) : base(name)
    {
    }

    public override void display(string message)
        {
            if (message.Equals("Всё мирно"))
                Console.WriteLine("Царьград: Наши выборы - самые честные выборы в мире!");
            else if (message.Equals("Вброс"))
                Console.WriteLine("Царьград: А в Америке вообще детей едят");
            else
                Console.WriteLine("Царьград: Царь победил!");

        }
    }