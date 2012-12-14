namespace MTree
{
    /// <summary>
    /// An object that can calculate the distance between two data objects.
    /// </summary>
    /// <typeparam name="T">The type of the data objects.</typeparam>
    public interface IDistanceFunction<in T>
    {
        double Calculate(T data1, T data2); 
    }
}
