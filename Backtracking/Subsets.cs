using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backtracking
{
    public class Subsets
    {
        public IList<IList<int>> GetSubsetList(int[] nums)
        {
            var results = new List<IList<int>>();
            if (nums == null || !nums.Any())
            {
                results.Add(new List<int>());
                return results;
            }

            var list = new List<int>(nums);
            list.Sort();

            var tmpList = new List<int>();
            int start = 0;
            GetSubsetListHelper(results, list, tmpList, start);

            return results;
        }

        public static List<IList<int>> GetSubsetList(List<int> list)
        {
            var results = new List<IList<int>>();
            if (list == null || !list.Any())
            {
                return results;
            }

            list.Sort();

            var tmpList = new List<int>();
            int start = 0;
            GetSubsetListHelper(results, list, tmpList, start);

            return results;
        }

        private static void GetSubsetListHelper(List<IList<int>> results, List<int> list, List<int> tmpList, int start)
        {
            if (start <= list.Count)
            {
                results.Add(new List<int>(tmpList));
            }
            else
            {
                return;
            }

            for (int i = start; i < list.Count; i++)
            {
                if (tmpList.Contains(list[i]))
                {
                    continue;
                }

                if (tmpList.Any() && tmpList[tmpList.Count - 1] > list[i])
                {
                    continue;
                }

                tmpList.Add(list[i]);
                GetSubsetListHelper(results, list, tmpList, start + 1);
                tmpList.RemoveAt(tmpList.Count - 1);
            }
        }
    }
}
