using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck cityDuck = new Duck(new SimpleQuack(), new SimpleFly());
            cityDuck.Display();
            Console.WriteLine();

            Duck rubberDuck = new Duck(new SimpleQuack(), new NoFly());
            rubberDuck.Display();
            Console.WriteLine();
        }
    }
}
