using System;
using System.Collections.Generic;

namespace MTree
{
    public class DistanceFunctions<T> : IDistanceFunction<T>
    {
        Dictionary<Pair, double> cache;
        private class Pair
        {
            private readonly T data1;
            private readonly T data2;
            
            public Pair(T data1, T data2)
            {
                this.data1 = data1;
                this.data2 = data2;
            }

            public override int GetHashCode()
            {
                return data1.GetHashCode() ^ data2.GetHashCode();
            }
            public override bool Equals(object obj)
            {
                if(obj is Pair)
                {
                    var that = obj as Pair;
                    return (data1.Equals(that.data1) && data2.Equals(that.data2));
                }
                return false;
            }
        }

        private DistanceFunctions()
        {
            
        }

        public IDistanceFunction<T> cached(IDistanceFunction<T> distanceFunction)
        {
            cache = new Dictionary<Pair, double>();
            

            throw new NotImplementedException();
        }

        public double Calculate(T data1, T data2)
        {
            Pair pair1 = new Pair(data1, data2);

            var distance = cache[pair1];

            if (distance != null)
            {
                return distance;
            }

            Pair pair2 = new Pair(data2, data1);
            distance = cache.get(pair2);
            if (distance != null)
            {
                return distance;
            }

            distance = distanceFunction.calculate(data1, data2);
            cache.put(pair1, distance);
            cache.put(pair2, distance);
            return distance;
        }
    }
    
}
