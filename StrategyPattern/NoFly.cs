using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class NoFly : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("No fly behavior");
        }
    }
}
