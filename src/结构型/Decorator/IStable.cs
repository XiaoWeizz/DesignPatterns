using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    /// <summary>
    /// 为了装饰而抽象出来的稳定的接口
    /// </summary>
    public interface IStable
    {
        /// <summary>
        /// 需要被扩展行为的方法
        /// </summary>
        void Operation();
    }
}