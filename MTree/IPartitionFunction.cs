using System.Collections.Generic;
using MTree.utils;

namespace MTree
{
    /// <summary>
    /// An object with partitions a set of data into two sub-sets.
    /// </summary>
    /// <typeparam name="T">The type of the data on the sets.</typeparam>
    public interface IPartitionFunction<T>
    {
        /// <summary>
        /// Executes the partitioning.
        /// </summary>
        /// <param name="promoted">The pair of data objects that will guide the partition process.</param>
        /// <param name="dataSet">The original set of data objects to be partitioned.</param>
        /// <param name="distanceFunction">A Distance function to be used on the partitioning</param>
        /// <returns>A pair of partition sub-sets. Each sub-set must correspond to one of the promoted data objects</returns>
        Pair<HashSet<T>> Process(Pair<T> promoted, HashSet<T> dataSet, IDistanceFunction<T> distanceFunction);
    }
}
