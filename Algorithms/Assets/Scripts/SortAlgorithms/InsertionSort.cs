public class InsertionSort {
    //Insertion Sort is a simple sorting algorithm that works similar to the way you sort playing cards in your hands.
    //The array is virtually split into a sorted and an unsorted part.
    //Values from the unsorted part are picked and placed at the correct position in the sorted part.
    //---Characteristics of Insertion Sort:
    //This algorithm is one of the simplest algorithm with simple implementation
    //Basically, Insertion sort is efficient for small data values
    //Insertion sort is adaptive in nature, i.e.it is appropriate for data sets which are already partially sorted.
    public static void Sort(int[] array) {
        for (int i = 1; i < array.Length; i++) {
            int temp = array[i];
            int j = i - 1;
            while (j >= 0 && array[j] > temp) {
                array[j + 1] = array[j];
                j--;
            }
            array[j + 1] = temp;
        }
    }

}
