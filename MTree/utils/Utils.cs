using System;
using System.Collections.Generic;

namespace MTree.utils
{
    public class Utils<T> where T : IComparable
    {
        private Utils()
        {
        }

        public static Pair<T> minMax(IEnumerable<T> items)
        {
            var iterator = items.GetEnumerator();
            if (!iterator.MoveNext())
            {
                return null;
            }

            T min = iterator.Current;
            T max = min;

            while (iterator.MoveNext())
            {
                var item = iterator.Current;
                if (item == null) continue;
                if (item.CompareTo(min) < 0)
                {
                    min = item;
                }
                else if (item.CompareTo(max) > 0)
                {
                    max = item;
                }
            }

            return new Pair<T>(min, max);
        }

        public static List<T> randomSample(IEnumerable<T> collection, int n)
        {
            var list = new List<T>(collection);
            var sample = new List<T>(n);
            Random random = new Random();
            while ((n > 0) && !(list.Count > 0))
            {
                var index = random.Next(list.Count);
                sample.Add(list[index]);
                var indexLast = list.Count - 1;
                if (list.Count > indexLast)
                {
                    var last = list[indexLast];
                    list.RemoveAt(indexLast);
                    if (index < indexLast)
                    {
                        list.Insert(index, last);
                    }
                }
                n--;
            }
            return sample;
        }
    }
}
