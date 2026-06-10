using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    public abstract class Node
    {
        protected string Name;

        protected Node(string name)
        {
            Name = name;
        }

        /// <summary>
        /// 树节点的添加方法。
        /// </summary>
        /// <param name="node"></param>
        public abstract void Add(Node node);
        /// <summary>
        /// 每个节点上的公共方法
        /// </summary>
        /// <param name="depth"></param>
        public abstract void Display(int depth);
    }
}