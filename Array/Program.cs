using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Array.Sort;
using Array.TwoPointers;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //SortTest();

            //FindTest();

            TwoPointersTest();
        }

        private static void TwoPointersTest()
        {
            var array = new int[] {1, 2, 7, 8};
            var m = 19;

            MinWindowLengthOfMaxNum inst = new MinWindowLengthOfMaxNum();

            Console.WriteLine(inst.FindTheMinWindowLength(array, m));
        }

        private static void FindTest()
        {
            var array = new int[] {40, 34, 7, 4, 3, 2, 9, 1};
            int k = 3;

            var finder = new ArrayFinder();
            Console.WriteLine(finder.FindKValue(array, 6));
        }

        private static void SortTest()
        {
            var testCases = new List<int[]>()
            {
                new []{9, 4, 3, 2, -1},
                new []{1, 2, 3, 4},
                new []{5, 3, 7, 2, 9, 0},
                new []{5, 3, 7, 2, 9, 0, -1, 2, 5, 3, 6, 1},
                new []{1, 1, 1},
                new []{0}
            };

            //var sort = new BubbleSort();
            //var sort = new SelectSort();
            //var sort = new InsertSort();
            //var sort = new QuickSort();
            var sort = new MergeSort();

            foreach (var inst in testCases)
            {
                Console.WriteLine("Origin: {0}", string.Join(", ", inst));
                //var res = sort.SortRecursively(inst);
                //var res = sort.SortNonRecursively(inst);
                var res = sort.Sort(inst);
                Console.WriteLine("Sorted: {0}", string.Join(", ", res));
            }
        }
    }
}
