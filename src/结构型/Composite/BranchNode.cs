using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DesignPatterns.Composite
{
    public class BranchNode : Node
    {
        private readonly List<Node> _children = new();

        public BranchNode(string name) : base(name)
        {
        }

        /// <summary>
        /// 分支节点添加子节点
        /// </summary>
        /// <param name="node"></param>
        public override void Add(Node node)
        {
            _children.Add(node);
        }

        /// <summary>
        /// 分支节点实现节点公共方法。
        /// </summary>
        /// <param name="depth"></param>
        public override void Display(int depth)
        {
            Console.WriteLine($"{new string('-', depth)} {Name}");
            foreach (var node in _children)
            {
                node.Display(depth + 2);
            }
        }
    }
}