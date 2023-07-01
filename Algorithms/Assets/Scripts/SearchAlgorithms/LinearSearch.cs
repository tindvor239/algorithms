using System;

namespace Algorithms.Search {
    public class LinearSearch<T> {
        public static T Search(T[] array, T searchElement) {
            for (int i = 0; i < array.Length; i++) {
                if (array[i].Equals(searchElement)) {
                    return array[i];
                }
            }
            throw new ArgumentOutOfRangeException(string.Format("Search element not in array {0}", searchElement));
        }
    }
}