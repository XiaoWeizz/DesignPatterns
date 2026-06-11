using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public class DecoratorB : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            AddBehavior();
        }

        private void AddBehavior()
        {
            Console.WriteLine("装饰器DecoratorB，在原始行为后增加了行为");
        }
    }
}