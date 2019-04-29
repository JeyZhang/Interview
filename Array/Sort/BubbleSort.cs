using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.Sort
{
    public class BubbleSort:ISort
    {
        public int[] Sort(int[] array)
        {
            if (array == null || array.Length < 2)
            {
                return array;
            }

            int len = array.Length;
            for (int i = 0; i < len; i++)
            {
                for (int j = len - 1; j > i; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        SortUtil.Swap(array, j - 1, j);
                    }
                }
            }

            return array;
        }
    }
}
