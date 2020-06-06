using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class SimpleQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Simple quack behavior");
        }
    }
}
