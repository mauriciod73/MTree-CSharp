using System.Collections.Generic;
using System.Linq;

using MTree.utils;

namespace MTree
{
    /// <summary>
    /// Some pre-defined implementations of partition functions.
    /// </summary>
    public class PartitionFunctions
    {
        
        private PartitionFunctions()
        {

        }

        public class BalancedPartition<T> : IPartitionFunction<T>
        {
            public Pair<HashSet<T>> Process(Pair<T> promoted, HashSet<T> dataSet, IDistanceFunction<T> distanceFunction)
            {
                var comparador = new Comparador();
                var queue1 = new List<T>(dataSet.ToList());

                queue1.Sort(
                    (left, right) =>
                    {
                        var distance1 = distanceFunction.Calculate(left, promoted.First);
                        var distance2 = distanceFunction.Calculate(right, promoted.First);
                        return comparador.Compare(distance1, distance2);
                    }
                    );

                var queue2 = new List<T>(dataSet.ToArray());

                queue2.Sort(
                    (left, right) =>
                        {
                            var distance1 = distanceFunction.Calculate(left, promoted.Second);
                            var distance2 = distanceFunction.Calculate(right, promoted.Second);
                            return comparador.Compare(distance1, distance2);
                        }
                    );


                var partitions = new Pair<HashSet<T>>(new HashSet<T>(), new HashSet<T>());

                var index1 = 0;
                var index2 = 0;

                while (index1 < queue1.Count || index2 != queue2.Count)
                {
                    while (index1 < queue1.Count)
                    {
                        var data = queue1[index1++];
                        if (partitions.Second.Contains(data)) continue;
                        partitions.First.Add(data);
                        break;
                    }

                    while (index2 < queue2.Count)
                    {
                        var data = queue2[index2++];
                        if (partitions.First.Contains(data)) continue;
                        partitions.Second.Add(data);
                        break;
                    }
                }

                return partitions;
            }

        }
        private class Comparador : IComparer<double>
        {
            public int Compare(double x, double y)
            {
                return x.CompareTo(y);
            } 
        }
    }
}
