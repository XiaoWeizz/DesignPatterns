using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    /// <summary>
    /// 稳定的类，继承抽象出来的接口
    /// </summary>
    public class StableClass : IStable
    {
        public void Operation()
        {
            Console.WriteLine("这里是稳定类的原始方法。");
        }
    }
}