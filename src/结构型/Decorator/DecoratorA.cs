using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public class DecoratorA : Decorator
    {
        public override void Operation()
        {
            AddBehavior();
            base.Operation();
        }

        private void AddBehavior()
        {
            Console.WriteLine("装饰器DecoratorA，在原始行为前增加了行为");
        }
    }
}