using System;
using System.Collections.Generic;
using System.Text;

namespace _03._09
{
    class Basement : IParts
    {
        public uint PartsCount { get; set; }

        public Basement(uint PartsCount)
        {
            this.PartsCount = PartsCount;
        }
    }
}
