using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.Iterator
{
    public class BufferCollection<T> : IEnumerable<Tuple<T, T>>
    {
        private readonly IEnumerable<T> _items;

        public BufferCollection(IEnumerable<T> items)
        {
            _items = items;
        }

        public IEnumerator<Tuple<T, T>> GetEnumerator()
        {
            return new BufferIterator<T>(_items.ToList().GetEnumerator());
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
