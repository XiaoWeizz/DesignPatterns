using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge
{
    public class TcpTransport : ITransport
    {
        public void Connect()
        {
            Console.WriteLine($"这里是TCP的连接");
        }

        public void Send(byte[] data)
        {
            Console.WriteLine($"使用了TCP发送数据");
        }
    }
}