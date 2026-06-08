using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge
{
    public class SerialPortTransport : ITransport
    {
        public void Connect()
        {
            Console.WriteLine($"这里是串口的连接");
        }

        public void Send(byte[] data)
        {
            Console.WriteLine($"使用了串口发送数据");
        }
    }
}