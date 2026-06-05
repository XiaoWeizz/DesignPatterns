using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    public class ObjectAdapter
    {
        /// <summary>
        /// 被适配的对象引用
        /// </summary>
        Adaptee adaptee;
        /// <summary>
        /// 构造时输入被适配的对象
        /// </summary>
        /// <param name="adaptee"></param>
        public ObjectAdapter(Adaptee adaptee)
        {
            this.adaptee = adaptee;
        }

        /// <summary>
        /// 也是相加，但是增加一个偏移量
        /// </summary>
        /// <param name="arg1"></param>
        /// <param name="arg2"></param>
        /// <returns></returns>
        public int Handle(int arg1, int arg2)
        {
            int offset = 1;
            Console.WriteLine("这里是对象适配的处理, 增加偏移量1");
            var result = adaptee.Handle(arg1, arg2);
            return result + offset;
        }
    }
}