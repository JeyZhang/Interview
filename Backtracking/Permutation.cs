using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backtracking
{
    public class Permutation
    {
        public static IList<IList<int>> GetPermutations(List<int> list)
        {
            var results = new List<IList<int>>();
            if (list == null || !list.Any())
            {
                return results;
            }

            var tmpList = new List<int>();
            GetPermutationsHelper(results, list, tmpList);

            return results;
        }

        private static void GetPermutationsHelper(List<IList<int>> results, List<int> list, List<int> tmpList)
        {
            if (tmpList.Count == list.Count)
            {
                results.Add(new List<int>(tmpList));
                return;
            }

            for (int i = 0; i < list.Count; i++)
            {
                if (tmpList.Contains(list[i]))
                {
                    continue;
                }

                tmpList.Add(list[i]);
                GetPermutationsHelper(results, list, tmpList);
                tmpList.RemoveAt(tmpList.Count - 1);
            }
        }

        public static List<List<int>> GetUniquePermutations(List<int> list)
        {
            var results = new List<List<int>>();
            if (list == null || !list.Any())
            {
                return results;
            }

            var tmpList = new List<int>();
            list.Sort();

            var used = new List<bool>();
            foreach (var i in list)
            {
                used.Add(false);
            }

            GetPermutationsUniqueHelper(results, list, tmpList, used);

            return results;
        }

        private static void GetPermutationsUniqueHelper(List<List<int>> results, List<int> list, List<int> tmpList, List<bool> used)
        {
            if (tmpList.Count == list.Count)
            {
                results.Add(new List<int>(tmpList));
                return;
            }

            for (int i = 0; i < list.Count; i++)
            {
                if (used[i])
                {
                    continue;
                }

                if (i > 0 && list[i] == list[i - 1] && !used[i - 1])
                {
                    continue;
                }

                used[i] = true;
                tmpList.Add(list[i]);
                GetPermutationsUniqueHelper(results, list, tmpList, used);
                tmpList.RemoveAt(tmpList.Count - 1);
                used[i] = false;
            }
        }
    }
}
