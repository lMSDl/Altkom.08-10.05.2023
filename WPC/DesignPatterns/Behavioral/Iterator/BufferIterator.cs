using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.Iterator
{
    public class BufferIterator<T> : IEnumerator<Tuple<T, T>>
    {
        private IEnumerator<T> enumerator;

        public BufferIterator(IEnumerator<T> enumerator)
        {
            this.enumerator = enumerator;
            Reset();
        }

        public Tuple<T, T> Current { get; private set; }

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            enumerator.Dispose();
            enumerator = null;
            Current = default;
        }

        public bool MoveNext()
        {
            if (enumerator.MoveNext())
            {
                Current = new Tuple<T, T>(Current.Item2, enumerator.Current);
                return true;
            }
            return false;
        }

        public void Reset()
        {
            enumerator.Reset();
            if(enumerator.MoveNext())
            {
                Current = new Tuple<T, T>(default, enumerator.Current);
            }
            else
            {
                Current = default;
            }
        }
    }
}
