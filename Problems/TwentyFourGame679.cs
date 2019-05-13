using System;
using System.Collections.Generic;

namespace Problems
{
    public class TwentyFourGame679
    {
        public bool JudgePoint24(int[] nums)
        {
            if (nums == null || nums.Length != 4)
            {
                return false;
            }

            double gap = 0.00001;
            var input = new List<double>();
            foreach (var n in nums)
            {
                input.Add(n);
            }

            var permutations = GetUniquePermutations(input);
            foreach (var list in permutations)
            {
                if (JudgeHelperV1(list, new HashSet<double>(), gap) || JudgeHelperV2(list, gap))
                {
                    return true;
                }
            }

            return false;
        }

        private List<List<double>> GetUniquePermutations(List<double> input)
        {
            var results = new List<List<double>>();
            var count = input.Count;
            var used = new bool[count];
            var list = new List<double>();

            GetUniquePermutationsHelper(results, used, list, input);
            return results;
        }

        private void GetUniquePermutationsHelper(List<List<double>> results, bool[] used, List<double> list, List<double> input)
        {
            if (list.Count == input.Count)
            {
                results.Add(new List<double>(list));
                return;
            }

            for (int i = 0; i < input.Count; i++)
            {
                if (i > 0 && input[i - 1] == input[i] && !used[i - 1])
                {
                    continue;
                }

                if (used[i])
                {
                    continue;
                }

                used[i] = true;
                list.Add(input[i]);
                GetUniquePermutationsHelper(results, used, list, input);
                list.RemoveAt(list.Count - 1);
                used[i] = false;
            }
        }

        private bool JudgeHelperV1(List<double> inputs, HashSet<double> results, double gap)
        {
            if (inputs.Count == 0)
            {
                foreach (var res in results)
                {
                    if (Math.Abs(res - 24d) < gap)
                    {
                        return true;
                    }
                }
                return false;
            }

            var element = inputs[0];
            if (results.Count == 0)
            {
                results.Add(element);
            }
            else
            {
                var tmpSet = new HashSet<double>();
                foreach (var rs in results)
                {
                    var tmpRes = GetTwoNumsResults(rs, element);
                    tmpSet.UnionWith(tmpRes);
                }
                results = new HashSet<double>(tmpSet);
            }

            inputs.RemoveAt(0);
            if (JudgeHelperV1(inputs, results, gap))
            {
                return true;
            }
            inputs.Insert(0, element);

            return false;
        }

        private bool JudgeHelperV2(List<double> inputs, double gap)
        {
            var set1 = GetTwoNumsResults(inputs[0], inputs[1]);
            var set2 = GetTwoNumsResults(inputs[2], inputs[3]);
            foreach (var num1 in set1)
            {
                foreach (var num2 in set2)
                {
                    var ress = GetTwoNumsResults(num1, num2);
                    foreach (var res in ress)
                    {
                        if (Math.Abs(res - 24d) < gap)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        private HashSet<double> GetTwoNumsResults(double a, double b)
        {
            var results = new HashSet<double>();

            results.Add(a - b);
            results.Add(a + b);
            results.Add(b - a);
            results.Add(a * b);
            results.Add(a / b);
            results.Add(b / a);

            return results;
        }

    }
}
