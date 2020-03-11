using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.S._2020.Vyskvarko._01
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            int[] array = new int[11];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(100);
            }

            Console.Write("Source array:\t");
            ShowArray(array);

            Console.Write($"\n\nMerge Sort:\t");
            int[] resultMergeSort = MergeSort.Sort(array);
            ShowArray(resultMergeSort);

            Console.Write("\n\nQuick Sort:\t");
            int[] resultQuickSort = QuickSort.Sort(array);
            ShowArray(resultQuickSort);

            Console.ReadLine();
        }

        static void ShowArray(int[] array)
        {
            foreach (var arr in array)
            {
                Console.Write($"{arr} ");
            }
        }
    }
}
