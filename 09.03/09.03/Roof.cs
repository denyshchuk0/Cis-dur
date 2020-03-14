using System;
using System.Collections.Generic;
using System.Text;

namespace _03._09
{
    class Roof : IParts
    {
        public uint PartsCount { get; set; }

        public Roof(uint PartsCount)
        {
            this.PartsCount = PartsCount;
        }
    }
}
