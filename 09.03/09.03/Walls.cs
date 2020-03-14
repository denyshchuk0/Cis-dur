using System;
using System.Collections.Generic;
using System.Text;

namespace _03._09
{
    class Wall : IParts
    {
        public uint PartsCount { get; set; }

        public Wall(uint PartsCount)
        {
            this.PartsCount = PartsCount;
        }
    }
}
