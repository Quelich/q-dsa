namespace DataStructures
{
    public class InsertionSort
    {
         // Time Complexity: O(n^2) at the worst case
        public int[] Sort (int[] array) {

            // Traverse the sorted partition
            for (var firstUnsortedIndex = 1; firstUnsortedIndex < array.Length; firstUnsortedIndex++) {
                // Select the first unsorted element
                var newElement = array[firstUnsortedIndex];
                var i = 0;
                // Looking for appropriate position for the new element
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
