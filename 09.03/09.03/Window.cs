using System;
using System.Collections.Generic;
using System.Text;

namespace _03._09
{
    class Window : IParts
    {
        public uint PartsCount { get; set; }

        public Window(uint PartsCount)
        {
            this.PartsCount = PartsCount;
        }
    }
}
