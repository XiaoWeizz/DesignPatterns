using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Flyweight
{
    public class TextEditor
    {
        private readonly GlyphFactory _factory = new();
        private readonly List<Character> _document = new();  // 只管理上下文对象

        public void InsertChar(char c, int x, int y, int size, Color color)
        {
            var glyph = _factory.GetGlyph(c);          // 获取共享享元
            var character = new Character(glyph, x, y, size, color); // 封装外部状态
            _document.Add(character);                  // 只存上下文对象
            Console.WriteLine($"字母个数：{_document.Count}");
        }

        public void Render()
        {
            foreach (var character in _document)
            {
                character.Draw();  // Character.Draw → glyph.Draw(x, y, size, color)
            }
        }
    }
}