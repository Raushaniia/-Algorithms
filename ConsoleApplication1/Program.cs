using System;

namespace Search_by_unsorted_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 4, 0, 3, 2, 2, 3, 4 , 6, 7, 6, 7};
            QuickSort(array, 0, array.Length -1);
            int uniq_el = array[array.Length - 1];
            for (int i = 0; i <= array.Length - 2; i+=2)
            {
                if (array[i] != array[i + 1])
                {
                    uniq_el = array[i];
                    break;
                }
               
            }
            Console.WriteLine(uniq_el);
            Console.ReadLine();
        }
        public static int Partition(int[] array, int start, int end)
        {
            int marker = start;
            for (int i = start; i <= end; i++) {
                if (array[i] <= array[end])
                {
                    int temp = array[marker];
                    array[marker] = array[i];
                    array[i] = temp;
                    marker += 1; 
                }
            }
            return marker - 1;
        }

        public static void QuickSort(int[] array, int start, int end)
        {
            if (start >= end)
                return;
            int marked_elem = Partition(array, start, end);
            QuickSort(array, marked_elem + 1, end);
            QuickSort(array, start , marked_elem - 1);
        }
    }
}
