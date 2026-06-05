using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    public class ClassAdapter : Adaptee
    {
        /// <summary>
        /// 重写被适配的方法，增加偏移量
        /// </summary>
        /// <param name="arg1"></param>
        /// <param name="arg2"></param>
        /// <returns></returns>
        public new int Handle(int arg1, int arg2)
        {
            int offset = 2;
            Console.WriteLine("这里是类适配的处理, 增加偏移量2");
            var result = base.Handle(arg1, arg2);
            return result + offset;
        }
    }
}