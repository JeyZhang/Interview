using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backtracking
{
    class Program
    {
        static void Main(string[] args)
        {
            //PermutationTest();
            NQueenTest();
        }

        private static void NQueenTest()
        {
            var nqueen = new NQueen51();
            var result = nqueen.SolveNQueens(8);

            foreach (var res in result)
            {
                foreach (var str in res)
                {
                    Console.WriteLine(str);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Count: {0}", result.Count);
        }

        private static void PermutationTest()
        {
            #region Permutation

            if (false)
            {
                var list = new List<int>(){1, 2, 3};
                var results = Permutation.GetPermutations(list);
                foreach (var res in results)
                {
                    Console.WriteLine(string.Join(", ", res));
                }
            }

            #endregion

            #region Unique Permutation

            if (false)
            {
                var list = new List<int>() { 3, 2, 1, 1, 4, 1, 4, 3 };
                var results = Permutation.GetUniquePermutations(list);
                foreach (var res in results)
                {
                    Console.WriteLine(string.Join(", ", res));
                }
            }

            #endregion

            #region Subsets

            if (true)
            {
                var list = new List<int>(){1, 2, 3};
                var results = Subsets.GetSubsetList(list);
                foreach (var res in results)
                {
                    Console.WriteLine(string.Join(", ", res));
                }
            }

            #endregion
        }
    }
}
