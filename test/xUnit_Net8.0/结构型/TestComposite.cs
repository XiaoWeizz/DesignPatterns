using DesignPatterns.Composite;
using DesignPatterns.Test.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;

namespace DesignPatterns.Test.结构型
{
    public class TestComposite : ConsoleCaptureTestBase
    {
        public TestComposite(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public void TestDisplay()
        {
            var root = new BranchNode("root");
            root.Add(new LeafNode("Leaf A"));
            root.Add(new LeafNode("Leaf B"));

            var co = new BranchNode("Branch A");
            co.Add(new LeafNode("Leaf X"));
            co.Add(new LeafNode("Leaf Y"));
            var co1 = new BranchNode("Branch B");
            co1.Add(new LeafNode("Leaf P"));
            co1.Add(new LeafNode("Leaf Q"));

            co.Add(co1);
            root.Add(co);
            root.Display(0);

            // 这一行会把被测代码的 Console 输出全部打印到测试结果（点击测试用例查看右边的输出结果）
            FlushConsoleOutput();
        }
    }
}
