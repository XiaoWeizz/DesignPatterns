using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    /// <summary>
    /// 被适配的类
    /// 假设这个是第三方的类，只能看到方法
    /// </summary>
    public class Adaptee
    {
        /// <summary>
        /// 可能是唯一有用的方法
        /// </summary>
        /// <param name="arg1"></param>
        /// <param name="arg2"></param>
        /// <returns></returns>
        public int Handle(int arg1, int arg2)
        {
            // 这里是看不见的第三方代码
            Console.WriteLine("这里是第三方的处理, 相加返回");
            return arg1 + arg2;
        }
        // 其他方法忽略了。
    }
}