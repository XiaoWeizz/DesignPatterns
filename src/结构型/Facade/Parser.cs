using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Facade
{
    /// <summary>
    /// 编译器的子类
    /// </summary>
    internal class Parser
    {
        public void Parse()
        {
            Console.WriteLine("源码解析");
        }
    }
}