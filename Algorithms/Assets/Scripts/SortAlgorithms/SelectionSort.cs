public class SelectionSort {
    //The selection sort algorithm sorts an array by repeatedly.
    //Finding the minimum element (considering ascending order) from the unsorted part and putting it at the beginning. 
    //The algorithm maintains two subarrays in a given array.
    // * The subarray which already sorted.
    // * The remaining subarray was unsorted.
    //In every iteration of the selection sort.
    //The minimum element(considering ascending order) from the unsorted subarray is picked and swap to the beginning of unsorted subarray.
    //After every iteration sorted subarray size increase by one and unsorted subarray size decrease by one.


    public static void Sort(int[] array) {
        int minimumIndex;
        for (int i = 0; i < array.Length - 1; i++) {
            minimumIndex = i;
            for (int j = i + 1; j < array.Length; j++) {
                if (array[minimumIndex] > array[j]) {
                    minimumIndex = j;
                }
            }
            if (minimumIndex != i) {
                Utilities.Swap(array, i, minimumIndex);
            }
        }
    }
}
