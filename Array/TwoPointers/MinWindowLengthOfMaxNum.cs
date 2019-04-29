using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.TwoPointers
{
    /// <summary>
    /// 给定一个无序数组和数值m，找到超过m的子串和对应的最短窗口大小
    /// </summary>
    public class MinWindowLengthOfMaxNum
    {
        public int FindTheMinWindowLength(int[] array, int m)
        {
            if (array == null || array.Length < 1)
            {
                return -1;
            }

            if (m <= 0)
            {
                return 1;
            }

            int i = 0, j = 0;
            int sum = 0;
            var length = int.MaxValue;

            while (j < array.Length)
            {
                if (sum < m)
                {
                    sum += array[j++];
                    continue;
                }

                while (sum >= m && i < array.Length)
                {
                    sum -= array[i++];
                }

                length = Math.Min(length, j - i + 1);
            }

            if (j == array.Length && sum >= m)
            {
                while (sum >= m && i < array.Length)
                {
                    sum -= array[i++];
                }

                length = Math.Min(length, j - i + 1);
            }

            return length;
        }
    }
}
