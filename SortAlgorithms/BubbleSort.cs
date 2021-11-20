using System;
using System.Diagnostics;

namespace DataStructures {

    public class SortAlgorithms
    {
        // Time Complexity: O(n^2) at the worst case
        public int[] BubbleSort(int[] array)
        {
            var unsortedPartitionIndex = array.Length - 1;
            var temp = 0;
            for (var j = unsortedPartitionIndex; j > 0; j--)
            {
                for (var i = 0; i < unsortedPartitionIndex; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
            }
            return array;
        }
    }
}