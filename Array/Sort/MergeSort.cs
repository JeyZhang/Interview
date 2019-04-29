using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.Sort
{
    public class MergeSort:ISort
    {
        private int[] Copy;

        public int[] Sort(int[] array)
        {
            if (array == null || array.Length < 2)
            {
                return array;
            }

            Copy = new int[array.Length];

            SortByRecursive(array, 0, array.Length - 1);

            return array;
        }

        private void SortByRecursive(int[] array, int start, int end)
        {
            if (end <= start)
            {
                return;
            }

            int mid = start + (end - start) / 2;
            SortByRecursive(array, start, mid);
            SortByRecursive(array, mid + 1, end);
            MergeArray(array, start, mid, end);
        }

        private void MergeArray(int[] array, int start, int mid, int end)
        {
            int i = start, j = mid + 1;
            int k = start;

            while (i <= mid && j <= end)
            {
                if (array[i] <= array[j])
                {
                    Copy[k++] = array[i++];
                }
                else
                {
                    Copy[k++] = array[j++];
                }
            }

            while (i <= mid)
            {
                Copy[k++] = array[i++];
            }

            while (j <= end)
            {
                Copy[k++] = array[j++];
            }

            // copy to origin array
            for (int l = start; l <= end; l++)
            {
                array[l] = Copy[l];
            }
        }
    }
}
