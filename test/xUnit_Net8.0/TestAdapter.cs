using DesignPatterns.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Test
{
    public class TestAdapter
    {
        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(4, 4)]
        public void TestHandle(int arg1, int arg2)
        {
            ClassAdapter classAdapter = new ClassAdapter();
            ObjectAdapter objectAdapter = new ObjectAdapter(new Adaptee());

            var result1 = classAdapter.Handle(arg1, arg2);
            var result2 = objectAdapter.Handle(arg1, arg2);

            Assert.Equal((arg1 + arg2 + 2), result1);
            Assert.Equal((arg1 + arg2 + 1), result2);
        }
    }
}
