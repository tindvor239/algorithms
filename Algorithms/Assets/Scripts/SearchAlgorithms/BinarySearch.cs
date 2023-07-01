using System;
using UnityEngine;

namespace Algorithms.Search {
    public class BinarySearch<T> where T : IComparable {
        public static T Search(T[] array, T searchElement) {
            int leftIndex = 0;
            int rightIndex = array.Length - 1;
            return SplitInHaft(array, searchElement, leftIndex, rightIndex);
        }

        private static T SplitInHaft(T[] array, T searchElement, int leftIndex, int rightIndex) {
            int middleIndex = leftIndex + (rightIndex - 1) / 2;
            Debug.Log("Middle Index: " + middleIndex + ", Value: " + array[middleIndex]);
            if (rightIndex < 1) {
                throw new ArgumentOutOfRangeException($"Search element not exist in the array {nameof(rightIndex)} = {rightIndex}");
            }
            if (searchElement.CompareTo(array[middleIndex]) == 0) {
                return array[middleIndex];
            }

            Debug.Log(searchElement + " Is Greater " + array[middleIndex] + ": " + (searchElement.CompareTo(array[middleIndex]) > 0));
            if (searchElement.CompareTo(array[middleIndex]) > 0) {
                Debug.Log("Left of array value: " + array[middleIndex] + ", Right of array value: " + array[rightIndex]);
                return SplitInHaft(array, searchElement, middleIndex + 1, rightIndex);
            }
            return SplitInHaft(array, searchElement, leftIndex, middleIndex - 1);
        }
    }
}