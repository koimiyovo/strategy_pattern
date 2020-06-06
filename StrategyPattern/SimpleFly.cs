using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class SimpleFly : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Simple fly behavior");
        }
    }
}
