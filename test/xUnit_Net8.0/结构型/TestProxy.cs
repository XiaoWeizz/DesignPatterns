using DesignPatterns.Proxy;
using DesignPatterns.Test.core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;

namespace DesignPatterns.Test.结构型
{
    public class TestProxy : ConsoleCaptureTestBase
    {
        public TestProxy(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public void TestRequest()
        {
            var proxy = new Proxy.Proxy(new RealSubject());
            proxy.Request();

            // 这一行会把被测代码的 Console 输出全部打印到测试结果（点击测试用例查看右边的输出结果）
            FlushConsoleOutput();
        }
    }
}
