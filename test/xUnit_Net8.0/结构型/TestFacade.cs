using DesignPatterns.Facade;
using DesignPatterns.Test.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;

namespace DesignPatterns.Test.结构型
{
    public class TestFacade : ConsoleCaptureTestBase
    {
        public TestFacade(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public void TestCompile()
        {
            Compiler compiler = new Compiler();
            compiler.Compile();

            // 这一行会把被测代码的 Console 输出全部打印到测试结果（点击测试用例查看右边的输出结果）
            FlushConsoleOutput();
        }
    }
}
