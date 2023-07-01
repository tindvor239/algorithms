namespace Algorithms.Sort {
    public class MergeSort {
        //If the list has only one element, return the list and terminate. (Base case)
        //Split the list into two halves that are as equal in length as possible. (Divide)
        //Using recursion, sort both lists using mergesort. (Conquer)
        //Merge the two sorted lists and return the result. (Combine)

        public static void Sort(int[] array, int leftIndex = 0, int rightIndex = -1) {
            if (rightIndex == -1) {
                rightIndex = array.Length - 1;
            }

            if (leftIndex < rightIndex) {
                int middleIndex = leftIndex + (rightIndex - leftIndex) / 2;
                Sort(array, leftIndex, middleIndex);
                Sort(array, middleIndex + 1, rightIndex);
                Merge(array, leftIndex, middleIndex, rightIndex);
            }
        }

        private static void Merge(int[] array, int leftIndex, int middleIndex, int rightIndex) {
            int leftArrayLength = middleIndex - leftIndex + 1;
            int rightArrayLength = rightIndex - middleIndex;
            int[] leftArray = new int[leftArrayLength];
            int[] rightArray = new int[rightArrayLength];
            int i;
            int j;

            for (i = 0; i < leftArray.Length; ++i) {
                leftArray[i] = array[leftIndex + i];
            }
            for (j = 0; j < rightArray.Length; ++j) {
                rightArray[j] = array[middleIndex + 1 + j];
            }

            i = 0;
            j = 0;
            int k = leftIndex;
            while (i < leftArrayLength && j < rightArrayLength) {
                if (leftArray[i] <= rightArray[j]) {
                    array[k] = leftArray[i];
                    i++;
                }
                else {
                    array[k] = rightArray[j];
                    j++;
                }
                k++;
            }

            while (i < leftArrayLength) {
                array[k] = leftArray[i];
                i++;
                k++;
            }

            while (j < rightArrayLength) {
                array[k] = rightArray[j];
                j++;
                k++;
            }
        }
    }
}