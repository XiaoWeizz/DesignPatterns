using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy
{
    /// <summary>
    /// 代理类
    /// </summary>
    public class Proxy : Subject
    {
        private readonly Subject _subject;

        public Proxy(Subject subject) => _subject = subject;

        /// <summary>
        /// 应用通过代理类请求操作
        /// </summary>
        public override void Request()
        {
            // 增加控制逻辑
            Console.WriteLine("代理类增加了控制逻辑。");
            _subject.Request();
        }
    }
}