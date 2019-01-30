using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Player
{
    class RandomColorSkin : Skin
    {
        public override void Clear()
        {
            Console.Clear();
            for (var i = 0; i < 30; i++)
            {
                Console.WriteLine("\u058D");
            }
        }

        public override void Render(string text)
        {
            var random = new Random();
            var color = random.Next(0, 15);

            Console.ForegroundColor = (ConsoleColor)color;
            Console.WriteLine(text);
        }
    }
}
