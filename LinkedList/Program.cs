using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //ReverseListTest();
            //MergeListTest();
            SortListTest();
        }

        private static void SortListTest()
        {
            var node1 = new LinkedListNode() { Value = 5 };
            var node2 = new LinkedListNode() { Value = 5 };
            var node3 = new LinkedListNode() { Value = 5 };
            var node4 = new LinkedListNode() { Value = 5 };
            var node5 = new LinkedListNode() { Value = 5 };
            var node6 = new LinkedListNode() { Value = 5 };


            node1.Next = node2;
            node2.Next = node3;
            node3.Next = node4;
            node4.Next = node5;
            node5.Next = node6;

            LinkedListUtil.PrintList(node1);

            var head = SortList.Sort(node1);

            LinkedListUtil.PrintList(head);
        }

        private static void MergeListTest()
        {
            var node1 = new LinkedListNode() { Value = 1 };
            var node2 = new LinkedListNode() { Value = 4 };
            var node3 = new LinkedListNode() { Value = 7 };
            var node4 = new LinkedListNode() { Value = 10 };

            node1.Next = node2;
            node2.Next = node3;
            node3.Next = node4;

            var node11 = new LinkedListNode() { Value = 2 };
            var node22 = new LinkedListNode() { Value = 6 };
            var node33 = new LinkedListNode() { Value = 9 };
            var node44 = new LinkedListNode() { Value = 10 };

            node11.Next = node22;
            node22.Next = node33;
            node33.Next = node44;

            var newHead = MergeList.Merge(node1, node11);

            LinkedListUtil.PrintList(newHead);

        }

        private static void ReverseListTest()
        {
            var node1 = new LinkedListNode(){Value = 1};
            var node2 = new LinkedListNode() { Value = 2 };
            var node3 = new LinkedListNode() { Value = 3 };
            var node4 = new LinkedListNode() { Value = 4 };

            node1.Next = node2;
            node2.Next = node3;
            node3.Next = node4;

            LinkedListUtil.PrintList(node1);
            var reverse = new ReverseList();
            var newHead = reverse.Reverse(node1);
            LinkedListUtil.PrintList(newHead);


        }
    }
}
