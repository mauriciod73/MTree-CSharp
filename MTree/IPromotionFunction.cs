using System.Collections.Generic;
using MTree.utils;

namespace MTree
{
    /// <summary>
    /// An object that chooses a pair from a set of data objects.
    /// </summary>
    /// <typeparam name="T">The type of the data objects.</typeparam>
    public interface IPromotionFunction<T>
    {
        /// <summary>
        /// Chooses (promotes) a pair of objects according to some criteria that is
        /// suitable for the application using the M-Tree.
        /// </summary>
        /// <param name="dataSet">The set of objects to choose a pair from.</param>
        /// <param name="distanceFunction">A function that can be used for choosing the promoted objects.</param>
        /// <returns>A pair of chosen objects.</returns>
        Pair<T> Process(HashSet<T> dataSet, IDistanceFunction<T> distanceFunction); 
    }
}
