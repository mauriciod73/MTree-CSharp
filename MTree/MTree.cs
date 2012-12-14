using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTree
{
    /// <summary>
    /// The main class that implements M-Tree
    /// </summary>
    /// <typeparam name="Type">
    ///     The type of data that will be indexed by the M-Tree. 
    ///     Objects of this type are stored in HashMaps and HashSets, 
    ///     so their {@code hashCode()} and {@code equals()} methods must be consistent.
    /// </typeparam>
    public class MTree<Type>
    {
        public class ResultItem
        {
            /// <summary>
            /// A nearest neighbor
            /// </summary>
            public Type Data { get; set; }

            /// <summary>
            /// The distance from the nearest-neighbor to the query data object
		    /// parameter
            /// </summary>
            public double Distance { get; set; }
            
            private ResultItem(Type data, double distance)
            {
                Data = data;
                Distance = distance;
            }
        }

        //private static class SplitNodeReplacementException : Exception
        //{
            
        //}

        public class Query : IEnumerable<ResultItem>
        {
            public IEnumerator<ResultItem> GetEnumerator()
            {
                throw new NotImplementedException();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }
    }
}
