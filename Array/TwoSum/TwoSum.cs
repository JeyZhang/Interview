using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Array.TwoSum
{
    public class TwoSumSolution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var res = new int[] { 0, 0 };

            if (nums == null || nums.Length < 2)
            {
                return res;
            }

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    for (int j = i + 1; j < nums.Length; j++)
            //    {
            //        if (nums[i] + nums[j] == target)
            //        {
            //            res[0] = i;
            //            res[1] = j;

            //            return res;
            //        }
            //    }
            //}

            var dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                var remain = target - nums[i];
                if (dict.ContainsKey(remain))
                {
                    var remainIndex = dict[remain];
                    return i < remainIndex ? 
                        new int[] {i, remainIndex } : new int[] { remainIndex, i };
                }

                dict[nums[i]] = i;
            }

            return res;
        }
    }
}
