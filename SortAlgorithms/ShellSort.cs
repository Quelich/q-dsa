namespace DataStructures {
    public class ShellSort {
        public int[] Sort (int[] array) {
            for (var gap = array.Length / 2; gap > 0; gap /= 2) {
                for (var i = gap; i < array.Length;i++) {
                    var newElement = array[i];
                    var j = i;
                    while (j >= gap && array[j - gap] > newElement) {
                        array[j] = array[j - gap];
                        j -= gap;
                    }
                    array[j] = newElement;
                }
            }
            return array;
        }
    }
}