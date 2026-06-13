using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DesignPatterns.Flyweight
{
    public class GlyphFactory
    {
        private readonly ConcurrentDictionary<char, CharacterGlyph> _cache = new();
        public CharacterGlyph GetGlyph(char symbol)
        {
            var c = _cache.GetOrAdd(symbol, n => new CharacterGlyph(symbol));
            Console.WriteLine($"共享字母图元个数：{_cache.Count}");
            return c;
        }

    }
}