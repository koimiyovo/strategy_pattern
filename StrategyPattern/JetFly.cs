using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class JetFly : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Jet fly behavior");
        }
    }
}
