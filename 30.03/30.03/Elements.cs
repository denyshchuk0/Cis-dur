using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30._03
{
    class Elements : IEnumerable, IDisposable
    {
        List<int> elements = new List<int>();

        public Elements(List<int> elements)
        {
            this.elements = elements;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public void Sorting()
        {
            this.elements.Sort();
        }
        public IEnumerator GetEnumerator()
        {
            return elements.GetEnumerator();
        }
    }
}
