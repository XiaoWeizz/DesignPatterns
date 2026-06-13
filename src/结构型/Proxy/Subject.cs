using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy
{
    /// <summary>
    /// 原对象抽象出来的类
    /// </summary>
    public abstract class Subject
    {
        public abstract void Request();
    }
}