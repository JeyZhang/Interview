using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.Sort
{
    public class InsertSort : ISort
    {
        public int[] Sort(int[] array)
        {
            if (array == null || array.Length < 2)
            {
                return array;
            }

            var len = array.Length;
            for (int i = 1; i < len; i++)
            {
                int tmp = array[i];
                int insertIndex = i;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (array[j] > tmp)
                    {
                        array[j + 1] = array[j];
                        insertIndex = j;
                    }
                    else
                    {
                        break;
                    }
                }

                array[insertIndex] = tmp;
            }

            return array;
        }
    }
}
