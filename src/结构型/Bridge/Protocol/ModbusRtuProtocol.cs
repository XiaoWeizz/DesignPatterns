using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge
{
    public class ModbusRtuProtocol : Protocol
    {
        public override void Send(byte[] data)
        {
            Console.WriteLine($"使用了ModbusRtu协议组装报文内容");
            base.Send(data);
        }
    }
}