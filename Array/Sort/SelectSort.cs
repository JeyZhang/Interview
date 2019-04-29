using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.Sort
{
    public class SelectSort : ISort
    {
        public int[] Sort(int[] array)
        {
            if (array == null || array.Length < 2)
            {
                return array;
            }

            var len = array.Length;
            for (int i = 0; i < len; i++)
            {
                var minIndex = i;
                var minValue = array[i];

                for (int j = i + 1; j < len; j++)
                {
                    if (array[j] < minValue)
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    SortUtil.Swap(array, i, minIndex);
                }
            }

            return array;
        }
    }
}
