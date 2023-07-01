namespace Algorithms.Sort {
    public class HeapSort {
        public static void Sort(int[] array) {
            int max = array.Length;

            // Build heap (rearrange array)
            for (int i = max / 2 - 1; i >= 0; i--)
                Heapify(array, max, i);

            // One by one extract an element from heap
            for (int i = max - 1; i > 0; i--) {
                // Move current root to end
                Utilities.Swap(array, 0, i);

                // call max heapify on the reduced heap
                Heapify(array, i, 0);
            }
        }

        private static void Heapify(int[] array, int max, int index) {
            int largest = index; // Initialize largest as root
            int left = 2 * index + 1; // left = 2*i + 1
            int right = 2 * index + 2; // right = 2*i + 2

            // If left child is larger than root
            if (left < max && array[left] > array[largest])
                largest = left;

            // If right child is larger than largest so far
            if (right < max && array[right] > array[largest])
                largest = right;

            // If largest is not root
            if (largest != index) {
                Utilities.Swap(array, index, largest);

                // Recursively heapify the affected sub-tree
                Heapify(array, max, largest);
            }
        }
    }
}