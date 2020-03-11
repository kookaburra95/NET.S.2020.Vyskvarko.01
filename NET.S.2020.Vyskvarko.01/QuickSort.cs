using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.S._2020.Vyskvarko._01
{
    /// <summary>
    /// This class implements Quick sort.
    /// </summary>
    class QuickSort
    {
        /// <summary>
        /// This method swaps two elements.
        /// </summary>
        /// <param name="firstElement">First element.</param>
        /// <param name="secondElement">Second element.</param>
        static void Swap(ref int firstElement, ref int secondElement)
        {
            var temp = firstElement;
            firstElement = secondElement;
            secondElement = temp;
        }

        /// <summary>
        /// This method sorts the array, using recursion, breaking it into sub-arrays.
        /// </summary>
        /// <param name="array">Source array.</param>
        /// <param name="minIndex">The minimum index in the array.</param>
        /// <param name="maxIndex">The maximum index in the array.</param>
        /// <returns>Returns a sorted array.</returns>
        static int[] Sort(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }

            int pivot = Partition(array, minIndex, maxIndex);
            Sort(array, minIndex, pivot - 1);
            Sort(array, pivot + 1, maxIndex);

            return array;
        }

        /// <summary>
        /// This method returns an array with a minimum and maximum index.
        /// </summary>
        /// <param name="array">Source array.</param>
        /// <returns>Array with a minimum and maximum index.</returns>
        public static int[] Sort(int[] array)
        {
            return Sort(array, 0, array.Length - 1);
        }

        /// <summary>
        /// This method returns the pivot index of the element, which divides the array into elements smaller than pivot on the left,
        /// and elements larger than pivot on the right. In the method itself, the last element is selected as pivot,
        /// and traversal is carried out from the beginning of the array.
        /// </summary>
        /// <param name="array">Source array.</param>
        /// <param name="minIndex">The minimum index in the array.</param>
        /// <param name="maxIndex">The maximum index in the array.</param>
        /// <returns>Returns the pivot index of the item</returns>
        static int Partition(int[] array, int minIndex, int maxIndex)
        {
            var pivot = minIndex - 1;

            for (int i = minIndex; i < maxIndex; i++)
            {
                if (array[i] < array[maxIndex])
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                }
            }

            pivot++;
            Swap(ref array[pivot], ref array[maxIndex]);

            return pivot;
        }
    }
}
