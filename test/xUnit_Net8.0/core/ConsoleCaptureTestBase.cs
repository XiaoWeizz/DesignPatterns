using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;

namespace DesignPatterns.Test.core
{
    public abstract class ConsoleCaptureTestBase : IDisposable
    {
        private readonly ITestOutputHelper _output;
        private readonly TextWriter _originalConsoleOut;
        private readonly StringWriter _consoleCapture;

        protected ConsoleCaptureTestBase(ITestOutputHelper output)
        {
            _output = output;

            // 保存原始的 Console.Out
            _originalConsoleOut = Console.Out;

            // 创建一个拦截器
            _consoleCapture = new StringWriter();
            Console.SetOut(_consoleCapture);
        }

        // 在每个测试方法执行完后调用
        protected void FlushConsoleOutput()
        {
            var content = _consoleCapture.ToString();
            if (!string.IsNullOrEmpty(content))
            {
                _output.WriteLine("=== 被测试代码的 Console 输出 ===");
                _output.WriteLine(content);
                _output.WriteLine("=== Console 输出结束 ===");
            }

            // 清空捕获的内容，准备下一次捕获
            _consoleCapture.GetStringBuilder().Clear();
        }

        public void Dispose()
        {
            // 恢复原始的 Console.Out
            Console.SetOut(_originalConsoleOut);
            _consoleCapture?.Dispose();
        }
    }
}
