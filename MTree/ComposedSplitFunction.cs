using System.Collections.Generic;

namespace MTree
{
    public class ComposedSplitFunction<T> : ISplitFunction<T>
    {
        private IPromotionFunction<T> promotionFunction;
        private IPartitionFunction<T> partitionFunction;

        public ComposedSplitFunction(IPromotionFunction<T> promotionFunction, IPartitionFunction<T> partitionFunction)
        {
            this.promotionFunction = promotionFunction;
            this.partitionFunction = partitionFunction;
        }

        public SplitResult<T> process(HashSet<T> dataSet, IDistanceFunction<T> distanceFunction)
        {
            var promoted = promotionFunction.Process(dataSet, distanceFunction);
            var partitions = partitionFunction.Process(promoted, dataSet, distanceFunction);
            return new SplitResult<T>(promoted, partitions);
        }
    }
}
