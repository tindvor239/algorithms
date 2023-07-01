using System;
namespace Algorithms.Sort {
    public class QuickSort {
        //QuickSort is a Divide and Conquer algorithm.
        //It picks an element as a pivot and partitions the given array around the picked pivot.
        //There are many different versions of quickSort that pick pivot in different ways. 
        //Always pick the first element as a pivot.
        //Always pick the last element as a pivot (implemented below)
        //Pick a random element as a pivot.
        //Pick median as the pivot.

        public static void Sort(int[] array, int low = 0, int high = -1) {
            if (low == high) {
                return;
            }

            if (high == -1) {
                high = array.Length - 1;
            }
            else if (high < -1) {
                throw new ArgumentException(string.Format("Invalid Argument: {0} {1} is lower than -1.", nameof(high), high));
            }

            int i = Partition(array, low, high);
            Sort(array, low, i - 1);
            Sort(array, i, high);
        }

        private static int Partition(int[] array, int low, int high) {
            int pivot = array[high];
            int i = low - 1;

            for (int j = low; j <= high - 1; j++) {
                if (array[j] < pivot) {
                    i++;
                    Utilities.Swap(array, i, j);
                }
            }
            Utilities.Swap(array, i + 1, high);
            return i + 1;
        }
    }
}
