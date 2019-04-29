using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.Sort
{
    public class QuickSort
    {
        // 递归版本
        public int[] SortRecursively(int[] array)
        {
            if (array == null || array.Length < 2)
            {
                return array;
            }

            int len = array.Length - 1;
            SortRecursivelyHelper(array, 0, len);
            return array;
        }

        private void SortRecursivelyHelper(int[] array, int start, int end)
        {
            if (start >= end || start < 0 || end > array.Length - 1)
            {
                return;
            }

            int mid = Partition(array, start, end);
            SortRecursivelyHelper(array, start, mid - 1);
            SortRecursivelyHelper(array, mid + 1, end);
        }

        private int Partition(int[] array, int start, int end)
        {
            end += 1;
            int pivot = start, value = array[start];

            while (true)
            {
                while (++start < end && array[start] <= value)
                {
                    ;
                }

                while (--end > start && array[end] >= value)
                {
                    ;
                }

                if (start < end)
                {
                    SortUtil.Swap(array, start, end);
                }
                else
                {
                    SortUtil.Swap(array, pivot, start - 1);
                    pivot = start - 1;
                    break;
                }
            }

            return pivot;
        }

        // 非递归版本
        public int[] SortNonRecursively(int[] array)
        {
            if (array == null || array.Length < 2)
            {
                return array;
            }

            var stack = new List<int>();
            stack.Add(0);
            stack.Add(array.Length - 1);

            while (true)
            {
                if (!stack.Any())
                {
                    break;
                }

                var end = stack[stack.Count - 1];
                stack.RemoveAt(stack.Count - 1);

                var start = stack[stack.Count - 1];
                stack.RemoveAt(stack.Count - 1);

                var mid = Partition(array, start, end);
                if (mid - 1 > start)
                {
                    stack.Add(start);
                    stack.Add(mid - 1);
                }

                if (mid + 1 < end)
                {
                    stack.Add(mid + 1);
                    stack.Add(end);
                }
            }

            return array;
        }
    }
}
