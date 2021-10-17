using System;
using DataStructures;

namespace DataStrutures {
    internal class Program {
        static void Main (string[] args) {

            var sol = new SortAlgorithms ();
            var arr = new int[] { 20, 35, -15, 7, 55, 1, -22 };

            var bubble = sol.BubbleSort (arr);
            var selection = sol.SelectionSort (arr);

            System.Console.WriteLine ("Bubble Sort");
            System.Console.WriteLine (string.Join (",", bubble));
            System.Console.WriteLine ("Selection Sort");
            System.Console.WriteLine (string.Join (",", selection));
        }
    }
}