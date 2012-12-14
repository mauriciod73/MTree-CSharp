using System;

namespace MTree.utils
{
    /// <summary>
    /// A pair of objects of the same type
    /// </summary>
    /// <typeparam name="T">the type of the objects within</typeparam>
    public class Pair<T>
    {
        /// <summary>
        /// the first object
        /// </summary>
        public T First { get; set; }


        /// <summary>
        /// The second object
        /// </summary>
        public T Second { get; set; }

        /// <summary>
        /// Creates a pair of null objects
        /// </summary>
        public Pair() { }

        /// <summary>
        /// Creates a pair with a set of objects
        /// </summary>
        /// <param name="first">the firts object</param>
        /// <param name="second">the second object</param>
        public Pair(T first, T second)
        {
            First = first;
            Second = second;
        }

        
        /// <summary>
        /// Accesses an object by its index. The first object has index 0, the second object has index 1.
        /// if the selected object isn't one of the correct values it throws an exception
        /// </summary>
        /// <param name="index">index ob the object to be accessed</param>
        /// <returns>the object in the index</returns>
        public T get(int index)
        {
            T valor;
            switch (index)
            {
                case 0:
                    valor = First;
                    break;
                case 1:
                    valor = Second;
                    break;
                default: throw new ArgumentOutOfRangeException();
            }
            return valor;
        }
    }
}
