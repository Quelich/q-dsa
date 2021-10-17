using System;
using System.Diagnostics;

namespace DataStructures {
    // Time Complexity: O(n^2) at the worst case
    public class SortAlgorithms {
        public int[] BubbleSort (int[] array) {
            var unsortedPartitionIndex = array.Length - 1;
            var temp = 0;
            for (var j = unsortedPartitionIndex; j > 0; j--) {
                for (var i = 0; i < unsortedPartitionIndex; i++) {
                    if (array[i] > array[i + 1]) {
                        temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
            }
            return array;
        }

        public int[] SelectionSort (int[] array) {
            var unsortedPartitionIndex = array.Length - 1;
            var largestIndex = 0;
            var temp = 0;
            for (var j = unsortedPartitionIndex; j > 0; j--) {
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