using System.Collections.Generic;

namespace MTree
{
    /// <summary>
    /// Defines an object to be used to split a node in an M-Tree. A node must be
    /// split when it has reached its maximum capacity and a new child node would be
    /// added to it. 
    /// The splitting consists in choosing a pair of "promoted" data objects from
    /// the children and then partition the set of children in two partitions
    /// corresponding to the two promoted data objects.
    /// </summary>
    /// <typeparam name="T">The type of the data objects.</typeparam>
    public interface ISplitFunction<T>
    {
        /// <summary>
        /// Processes the splitting of a node.
        /// </summary>
        /// <param name="dataSet">A set of data that are keys to the children of the node to be split.</param>
        /// <param name="distanceFunction">A distance function that can be used to help splitting the node.</param>
        /// <returns>A SplitResult object with a pair of promoted data objects and a pair of corresponding partitions of the data objects.</returns>
        SplitResult<T> process(HashSet<T> dataSet, IDistanceFunction<T> distanceFunction);
    }
}
