using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DesignPatterns.Composite
{
    public class LeafNode : Node
    {
        public LeafNode(string name) : base(name)
        {
        }

        /// <summary>
        /// 叶子节点，不需要该方法。
        /// </summary>
        /// <param name="node"></param>
        /// <exception cref="System.NotImplementedException"></exception>
        public override void Add(Node node)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// 叶子节点实现公共方法。
        /// </summary>
        /// <param name="depth"></param>
        public override void Display(int depth)
        {
            Console.WriteLine($"{new string('-', depth)} {Name}");
        }
    }
}