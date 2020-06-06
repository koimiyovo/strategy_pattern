using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class NoQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("No quack behavior");
        }
    }
}
