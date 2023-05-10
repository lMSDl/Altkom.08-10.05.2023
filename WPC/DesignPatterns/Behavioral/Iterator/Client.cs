using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.Iterator
{
    public class Client
    {
        public static void Execute()
        {
            List<string> list = new List<string> { "1", "2", "3", "4" };

            var buffer = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                Console.WriteLine(buffer + list[i]);
                buffer = list[i];
            }

            var bufferCollection = new BufferCollection<string>(list);
            var bufferIterator = bufferCollection.GetEnumerator();
            while(bufferIterator.MoveNext())
            {
                Console.WriteLine(bufferIterator.Current.Item1 + bufferIterator.Current.Item2);
            }

            bufferIterator = bufferCollection.GetEnumerator();
            foreach (var item in new BufferCollection<string>(list))
            {
                Console.WriteLine(item.Item1 + item.Item2);

                if(bufferIterator.MoveNext())
                {
                    Console.WriteLine(bufferIterator.Current.Item2 + bufferIterator.Current.Item1);
                    if (bufferIterator.MoveNext())
                    {
                        Console.WriteLine(bufferIterator.Current.Item2 + bufferIterator.Current.Item1);
                    }
                }
            }

        }
    }
}
