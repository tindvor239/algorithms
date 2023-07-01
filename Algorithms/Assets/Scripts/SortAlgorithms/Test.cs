public class Test {
    public static void SelectionSort(int[] array) {
        for (int i = 0; i < array.Length; i++) {
            int minIndex = i;
            for(int j = i + 1; j < array.Length; j++) {
                if (array[j] < array[minIndex]) {
                    minIndex = j;
                }
            }
            if (array[minIndex] != i) {
                int temp = array[i];
                array[i] = array[minIndex];
                array[minIndex] = temp;
            }
        }
    }

    public static void BubbleSort(int[] array) {
        for (int i = 0; i < array.Length - 1; i++) {
            for (int j = 0; j < array.Length - i - 1; j++) {
                if (array[j] > array[j + 1]) {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }

    public static void InsertionSort(int[] array) {
        for(int i = 1; i < array.Length; i++) {
            for(int j = i - 1; j >= 0; j--) {
                if (array[j] > array[j + 1]) {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
                else {
                    break;
                }
            }
        }
    }
}
