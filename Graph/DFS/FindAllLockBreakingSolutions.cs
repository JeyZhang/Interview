using System.Collections.Generic;

namespace Graph.DFS
{
    public class Node
    {
        public int Value { get; set; }
        public List<Node> Neighbors { get; set; } = new List<Node>();
    }
    /// <summary>
    /// 对于手机的九宫格，找出所有的解锁手势，最多连接9个点
    /// </summary>
    public class FindAllLockBreakingSolutions
    {
        private List<Node> InputNodesList;

        public FindAllLockBreakingSolutions()
        {
            InputNodesList = new List<Node>();

            var node1 = new Node(){Value = 1};
            var node2 = new Node() { Value = 2 };
            var node3 = new Node() { Value = 3 };
            var node4 = new Node() { Value = 4 };
            var node5 = new Node() { Value = 5 };
            var node6 = new Node() { Value = 6 };
            var node7 = new Node() { Value = 7 };
            var node8 = new Node() { Value = 8 };
            var node9 = new Node() { Value = 9 };

            node1.Neighbors.Add(node2);
            node1.Neighbors.Add(node4);
            node1.Neighbors.Add(node5);

            node2.Neighbors.Add(node1);
            node2.Neighbors.Add(node3);
            node2.Neighbors.Add(node4);
            node2.Neighbors.Add(node5);
            node2.Neighbors.Add(node6);

            node3.Neighbors.Add(node2);
            node3.Neighbors.Add(node5);
            node3.Neighbors.Add(node6);

            node4.Neighbors.Add(node1);
            node4.Neighbors.Add(node2);
            node4.Neighbors.Add(node5);
            node4.Neighbors.Add(node7);
            node4.Neighbors.Add(node8);

            node5.Neighbors.Add(node1);
            node5.Neighbors.Add(node2);
            node5.Neighbors.Add(node3);
            node5.Neighbors.Add(node4);
            node5.Neighbors.Add(node6);
            node5.Neighbors.Add(node7);
            node5.Neighbors.Add(node8);
            node5.Neighbors.Add(node9);

            node6.Neighbors.Add(node2);
            node6.Neighbors.Add(node3);
            node6.Neighbors.Add(node5);
            node6.Neighbors.Add(node8);
            node6.Neighbors.Add(node9);

            node7.Neighbors.Add(node4);
            node7.Neighbors.Add(node5);
            node7.Neighbors.Add(node8);

            node8.Neighbors.Add(node4);
            node8.Neighbors.Add(node5);
            node8.Neighbors.Add(node6);
            node8.Neighbors.Add(node7);
            node8.Neighbors.Add(node9);

            node9.Neighbors.Add(node5);
            node9.Neighbors.Add(node6);
            node9.Neighbors.Add(node8);

            InputNodesList.Add(node1);
            InputNodesList.Add(node2);
            InputNodesList.Add(node3);
            InputNodesList.Add(node4);
            InputNodesList.Add(node5);
            InputNodesList.Add(node6);
            InputNodesList.Add(node7);
            InputNodesList.Add(node8);
            InputNodesList.Add(node9);
        }

        public List<string> GetSolutions()
        {
            var hashSet = new HashSet<string>();
            dfs(InputNodesList[0], hashSet, "");
            return new List<string>(hashSet);
        }

        private void dfs(Node node, HashSet<string> hashSet, string solution)
        {
            if (solution.Length == 9 || solution.Contains(node.Value+""))
            {
                return;
            }

            if (!string.IsNullOrEmpty(solution))
            {
                hashSet.Add(solution);
            }

            foreach (var nd in node.Neighbors)
            {
                dfs(nd, hashSet, solution + node.Value);
            }
        }
    }
}
