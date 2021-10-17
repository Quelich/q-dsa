using System;
using System.Diagnostics;

namespace DataStructures {

    public class SortAlgorithms {
        // Time Complexity: O(n^2) at the worst case
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

        // Time Complexity: O(n^2) at the worst case
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

        // Time Complexity: O(n^2) at the worst case
        public int[] InsertionSort (int[] array) {

            // Traverse the sorted partition
            for (var firstUnsortedIndex = 1; firstUnsortedIndex < array.Length; firstUnsortedIndex++) {
                // Select the first unsorted element
                var newElement = array[firstUnsortedIndex];
                var i = 0;
                for (i = firstUnsortedIndex; i > 0 && array[i-1] > newElement; i--) {
                    // Shifting from left to right
                    array[i] = array[i-1];
                }
                array[i] = newElement;
            }
            return array;
        }
    }
}