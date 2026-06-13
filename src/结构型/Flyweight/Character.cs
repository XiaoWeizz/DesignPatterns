using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Flyweight
{
    public class Character
    {
        private readonly CharacterGlyph _glyph;  // 共享的享元引用

        // 外部状态封装在这里
        public int X { get; set; }
        public int Y { get; set; }
        public int FontSize { get; set; }
        public Color Color { get; set; }

        public Character(CharacterGlyph glyph, int x, int y, int size, Color color)
        {
            _glyph = glyph;
            X = x;
            Y = y;
            FontSize = size;
            Color = color;
        }

        /// <summary>
        /// 委托给享元，传入自己的外部状态
        /// </summary>
        public void Draw()
        {
            _glyph.Draw(X, Y, FontSize, Color);
        }
    }
}