using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class Duck
    {
        private IQuackBehavior quackBehavior;
        private IFlyBehavior flyBehavior;

        public Duck(IQuackBehavior quackBehavior, IFlyBehavior flyBehavior)
        {
            this.quackBehavior = quackBehavior;
            this.flyBehavior = flyBehavior;
        }

        public void Fly()
        {
            this.flyBehavior.Fly();
        }

        public void Quack()
        {
            this.quackBehavior.Quack();
        }

        public void Display()
        {
            Quack();
            Fly();
        }
    }
}
