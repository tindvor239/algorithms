public class BubbleSort {
    //Bubble sort starts with very first two elements, comparing them to check which one is greater.
    //If the current element is larger than the next element.
    //Swap the current element with the next element.
    //Algorithm does not know if it is completed sorted and it's run until the pass times is end.
    //This algorithm is not suitable for large data sets as its average and worst-case time complexity is quite high
    public static void Sort(int[] array) {

        for (int passTime = 0; passTime < array.Length - 1; passTime++) {
            for (int index = 0; index < array.Length - passTime - 1; index++) {
                if (array[index] > array[index + 1]) {
                    Utilities.Swap(array, index, index + 1);
                }
            }
        }
    }
}
