using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.S._2020.Vyskvarko._01
{
    /// <summary>
    /// This class implements Merge sort.
    /// </summary>
    class MergeSort
    {
        /// <summary>
        /// This method recursively splits the array in the middle into left and right and passes them to the Merge method for sorting and merging.
        /// </summary>
        /// <param name="array">Source array.</param>
        /// <returns>Returns a sorted array.</returns>
        public static int[] Sort(int[] array)
        {
            int[] left;
            int[] right;
            int[] result = new int[array.Length];

            if (array.Length <= 1)
            {
                return array;
            }

            var mid = array.Length / 2;
            left = new int[mid];

            if (array.Length % 2 == 0)
            {
                right = new int[mid];
            }
            else
            {
                right = new int[mid + 1];
            }

            for (int i = 0; i < mid; i++)
            {
                left[i] = array[i];
            }

            var x = 0;
            for (int i = mid; i < array.Length; i++)
            {
                right[x] = array[i];
                x++;
            }

            left = Sort(left);
            right = Sort(right);

            result = Merge(left, right);

            return result;
        }
        /// <summary>
        /// This method compares the elements from the left and right arrays and adds them to the result array. Returns a merged array.
        /// </summary>
        /// <param name="left">Left array.</param>
        /// <param name="right">Right array.</param>
        /// <returns>Returns a merged array.</returns>
        private static int[] Merge(int[] left, int[] right)
        {
            var resultLength = right.Length + left.Length;
            int[] result = new int[resultLength];

            int indexLeft = 0, indexRight = 0, indexResult = 0;

            while (indexLeft < left.Length || indexRight < right.Length)
            {
                if (indexLeft < left.Length && indexRight < right.Length)
                {
                    if (left[indexLeft] <= right[indexRight])
                    {
                        result[indexResult] = left[indexLeft];
                        indexLeft++;
                        indexResult++;
                    }
                    else
                    {
                        result[indexResult] = right[indexRight];
                        indexRight++;
                        indexResult++;
                    }
                }
                else if (indexLeft < left.Length)
                {
                    result[indexResult] = left[indexLeft];
                    indexLeft++;
                    indexResult++;
                }
                else if (indexRight < right.Length)
                {
                    result[indexResult] = right[indexRight];
                    indexRight++;
                    indexResult++;
                }
            }

            return result;
        }
    }
}
