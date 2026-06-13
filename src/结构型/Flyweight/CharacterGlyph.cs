using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Flyweight
{
    /// <summary>
    /// 享元类，从字母类中剥离出来可以共享的部分，
    /// </summary>
    public class CharacterGlyph
    {
        public char Symbol { get; }

        /// <summary>
        /// 内部状态构造是传入
        /// </summary>
        /// <param name="symbol"></param>
        public CharacterGlyph(char symbol)
        {
            this.Symbol = symbol;
        }

        /// <summary>
        /// 外部状态在调用方法时由外部传入
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="size"></param>
        /// <param name="color"></param>
        public void Draw(int x, int y, int size, Color color)
        {
            // 绘制字母
            Console.WriteLine($"展示字母：{Symbol}，({x},{y},{size},{color})");
        }
    }
}