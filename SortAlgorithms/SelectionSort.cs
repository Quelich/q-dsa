namespace Datastructures
{
    public class SelectionSort
    {
       // Time Complexity: O(n^2) at the worst case
        public int[] Sort (int[] array) {
            var unsortedPartitionIndex = array.Length - 1;
            var largestIndex = 0;
            var temp = 0;
            for (var j = unsortedPartitionIndex; j > 0; j--) {
                // find the largest element in the unsorted partition
                for (var i = 1; i < unsortedPartitionIndex; i++) {
                    if (array[i] >= array[largestIndex]) {
                        largestIndex = i;
                    }
                }
                temp = array[unsortedPartitionIndex];
                array[unsortedPartitionIndex] = array[largestIndex];
                array[largestIndex] = temp;
                temp = 0;
            }
            return array;
        }
    }
}