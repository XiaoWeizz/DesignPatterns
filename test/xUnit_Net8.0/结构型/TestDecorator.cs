using DesignPatterns.Decorator;
using DesignPatterns.Test.core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;

namespace DesignPatterns.Test.结构型
{
    public class TestDecorator : ConsoleCaptureTestBase
    {
        public TestDecorator(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public void TestOperation()
        {
            // 实例化原始方法类
            StableClass stableClass = new StableClass();
            // 装饰器A
            var decoratorA = new DecoratorA();
            decoratorA.SetStableClass(stableClass);
            decoratorA.Operation();
            Console.WriteLine("==========");
            // 装饰器B
            var decoratorB = new DecoratorB();
            decoratorB.SetStableClass(decoratorA);
            decoratorB.Operation();

            // 这一行会把被测代码的 Console 输出全部打印到测试结果（点击测试用例查看右边的输出结果）
            FlushConsoleOutput();
        }
    }
}
