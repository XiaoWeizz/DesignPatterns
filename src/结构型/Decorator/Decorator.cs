using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    /// <summary>
    /// 这个抽象的装饰器类不用实现任何逻辑，
    /// 这个抽象类是为了可以无限嵌套的装饰。
    /// </summary>
    public abstract class Decorator : IStable
    {
        protected IStable StableClass;

        public void SetStableClass(IStable stableClass)
        {
            StableClass = stableClass;
        }

        public virtual void Operation()
        {
            StableClass.Operation();
        }
    }
}