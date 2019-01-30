using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Player
{
    abstract class Skin
    {
        public abstract void Clear();

        public abstract void Render(string text);
    }
}
