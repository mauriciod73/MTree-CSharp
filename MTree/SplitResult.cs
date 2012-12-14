using System.Collections.Generic;
using MTree.utils;

namespace MTree
{
    public class SplitResult<T>
    {
        /// <summary>
        /// A pair of promoted data objects.
        /// </summary>
        public Pair<T> Promoted { get; set; }

        /// <summary>
        /// A pair of partitions corresponding to the promoted data objects.
        /// </summary>
        public Pair<HashSet<T>> Partitions { get; set; }


        /// <summary>
        /// The constructor for a SplitResult object.
        /// </summary>
        public SplitResult(Pair<T> promoted, Pair<HashSet<T>> partitions)
        {
            Promoted = promoted;
            Partitions = partitions;
        }
    }
}
