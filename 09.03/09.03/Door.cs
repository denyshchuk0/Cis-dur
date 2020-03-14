using System;
using System.Collections.Generic;
using System.Text;

namespace _03._09
{
    class Door : IParts
    {
        public uint PartsCount { get; set; }

        public Door(uint PartsCount)
        {
            this.PartsCount = PartsCount;
        }
    }
}
