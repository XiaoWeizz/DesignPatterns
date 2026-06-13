using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Facade
{
    /// <summary>
    /// 编译器，外部只需要知道这个类就行了。
    /// </summary>
    public class Compiler
    {
        readonly Scanner scanner = new Scanner();
        readonly Parser parser = new Parser();
        readonly Builder builder = new Builder();
        public void Compile()
        {
            Console.WriteLine("开始编译");
            scanner.Scan();
            parser.Parse();
            builder.Build();
            Console.WriteLine("结束编译");
        }
    }
}