using Array.Sort;

namespace Array
{
    public class ArrayFinder
    {
        public int FindKValue(int[] array, int k) // 找到第k大的
        {
            if (array == null || array.Length == 0 || k <= 0 || k > array.Length)
            {
                return int.MinValue;
            }

            int value = 0;
            int start = 0, end = array.Length - 1;

            while (true)
            {
                int partitionIndex = Partition(array, start, end);
                if (partitionIndex + 1 == k)
                {
                    value = array[partitionIndex];
                    break;
                }

                if (partitionIndex + 1 < k)
                {
                    start = partitionIndex + 1;
                }
                else
                {
                    end = partitionIndex - 1;
                }
            }

            return value;
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


    }
}
