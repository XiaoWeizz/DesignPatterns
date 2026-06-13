using DesignPatterns.Flyweight;
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
    public class TestFlyweight : ConsoleCaptureTestBase
    {
        public TestFlyweight(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public void TestCompile()
        {
            TextEditor textEditor = new TextEditor();
            textEditor.InsertChar('A', 1, 1, 10, Color.Blue);
            textEditor.InsertChar('A', 1, 2, 10, Color.Black);
            textEditor.InsertChar('B', 1, 3, 10, Color.Blue);
            textEditor.InsertChar('B', 1, 4, 10, Color.RebeccaPurple);
            textEditor.InsertChar('B', 1, 5, 10, Color.Yellow);
            textEditor.InsertChar('C', 1, 6, 10, Color.Blue);
            textEditor.InsertChar('C', 1, 7, 10, Color.Orange);

            textEditor.Render();

            // 这一行会把被测代码的 Console 输出全部打印到测试结果（点击测试用例查看右边的输出结果）
            FlushConsoleOutput();
        }
    }
}
