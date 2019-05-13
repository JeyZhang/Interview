using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Backtracking
{
    public class NQueen51
    {
        public IList<IList<string>> SolveNQueens(int n)
        {
            var results = new List<IList<string>>();
            if (n <= 0)
            {
                return results;
            }

            var solution = new List<List<char>>();
            var indexList = new List<Tuple<int, int>>();

            var path = new List<char>();
            for (int i = 0; i < n; i++)
            {
                path.Add('.');
            }

            SolveNQueensHelper(results, solution, n, indexList, path);
            return results;
        }

        private void SolveNQueensHelper(List<IList<string>> results, List<List<char>> solution, int n, 
            List<Tuple<int, int>> indexList, List<char> path)
        {
            if (solution.Count == n)
            {
                var list = new List<string>();
                foreach (var chars in solution)
                {
                    list.Add(string.Join("", chars));
                }
                results.Add(list);
                return;
            }

            if (solution.Any() && !solution[solution.Count - 1].Contains('Q'))
            {
                return;
            }

            for (int i = solution.Count; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    var isValid = true;
                    foreach (var index in indexList)
                    {
                        if (index.Item1 == i)
                        {
                            isValid = false;
                            break;
                        }

                        if (index.Item2 == j)
                        {
                            isValid = false;
                            break;
                        }

                        if (Math.Abs(index.Item1 - i) == Math.Abs(index.Item2 - j))
                        {
                            isValid = false;
                            break;
                        }
                    }

                    if (!isValid)
                    {
                        continue;
                    }

                    indexList.Add(new Tuple<int, int>(i, j));
                    path[j] = 'Q';
                    solution.Add(new List<char>(path));
                    path[j] = '.';

                    SolveNQueensHelper(results, solution, n, indexList, path);
                    
                    solution.RemoveAt(solution.Count - 1);
                    indexList.RemoveAt(indexList.Count - 1);
                }
            }
        }
    }
}
