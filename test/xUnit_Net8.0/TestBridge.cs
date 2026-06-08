using DesignPatterns.Bridge;
using DesignPatterns.Test.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;

namespace DesignPatterns.Test
{
    public class TestBridge : ConsoleCaptureTestBase
    {
        public TestBridge(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public void TestSendData()
        {
            TcpTransport tcpTransport = new TcpTransport();
            SerialPortTransport serialPortTransport = new SerialPortTransport();

            Dlt645Protocol dlt645Protocol = new Dlt645Protocol();
            ModbusRtuProtocol modbusRtuProtocol = new ModbusRtuProtocol();

            byte[] data = new byte[1];
            // 1.TCP+Dlt645
            dlt645Protocol.transport = tcpTransport;
            dlt645Protocol.Send(data);

            // 2.TCP+ModbusRtu
            modbusRtuProtocol.transport = tcpTransport;
            modbusRtuProtocol.Send(data);

            // 3.SerialPort+Dlt645
            dlt645Protocol.transport = serialPortTransport;
            dlt645Protocol.Send(data);

            // 4.SerialPort+ModbusRtu
            modbusRtuProtocol.transport = serialPortTransport;
            modbusRtuProtocol.Send(data);

            // 这一行会把被测代码的 Console 输出全部打印到测试结果（点击测试用例查看右边的输出结果）
            FlushConsoleOutput();
        }
    }
}
