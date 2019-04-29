using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class SortList
    {
        //public static LinkedListNode Sort(LinkedListNode head) // Merge sorting
        //{
        //    if (head == null || head.Next == null)
        //    {
        //        return head;
        //    }

        //    var mid = GetMiddleNodeOfList(head);
        //    var newStart = mid.Next;
        //    mid.Next = null;

        //    var sortedHeadA = Sort(head);
        //    var sortedHeadB = Sort(newStart);
        //    return MergeSortList(sortedHeadA, sortedHeadB);
        //}
        private static LinkedListNode node = new LinkedListNode();

        public static LinkedListNode Sort(LinkedListNode head) // Quick sorting
        {
            if (head == null || head.Next == null)
            {
                return head;
            }

            node.Next = head;
            SortHelper(head, null);

            return node.Next;
        }

        private static void SortHelper(LinkedListNode head, LinkedListNode end)
        {
            if (head == null || head.Next == null || head.Next == end)
            {
                return;
            }

            var res = Partition(head, end);
            SortHelper(res.Item1, res.Item2);
            SortHelper(res.Item2.Next == null ? null : res.Item2.Next, null);
        }

        private static Tuple<LinkedListNode, LinkedListNode, LinkedListNode> Partition(LinkedListNode head, LinkedListNode end)
        {
            if (node.Next == head)
            {
                node.Next = null;
            }

            var pivot = head;
            var value = pivot.Value;

            var cur = pivot.Next;
            pivot.Next = null;

            LinkedListNode headA = null;
            LinkedListNode headB = null;
            LinkedListNode tmpA = null;
            LinkedListNode tmpB = null;

            while (cur != end)
            {
                if (cur.Value <= value)
                {
                    if (headA == null)
                    {
                        headA = cur;
                        tmpA = headA;
                    }
                    else
                    {
                        tmpA.Next = cur;
                        tmpA = tmpA.Next;
                    }
                }
                else
                {
                    if (headB == null)
                    {
                        headB = cur;
                        tmpB = headB;
                    }
                    else
                    {
                        tmpB.Next = cur;
                        tmpB = tmpB.Next;
                    }
                }

                cur = cur.Next;
            }

            if (headA == null)
            {
                pivot.Next = headB == null ? end : headB;
                if (node.Next == null)
                {
                    node.Next = pivot;
                }
            }
            else
            {
                tmpA.Next = pivot;
                pivot.Next = headB == null ? end : headB;
                if (node.Next == null)
                {
                    node.Next = headA;
                }
            }

            if (tmpB != null)
            {
                tmpB.Next = end;
            }

            return new Tuple<LinkedListNode, LinkedListNode, LinkedListNode>(
                headA, pivot, headB
                );
        }

        private static LinkedListNode MergeSortList(LinkedListNode headA, LinkedListNode headB)
        {
            if (headA == null)
            {
                return headB;
            }

            if (headB == null)
            {
                return headA;
            }

            var dumpNode = new LinkedListNode();
            var cur = dumpNode;

            var pointerA = headA;
            var pointerB = headB;

            while (pointerA != null && pointerB != null)
            {
                if (pointerA.Value < pointerB.Value)
                {
                    cur.Next = pointerA;
                    pointerA = pointerA.Next;
                }
                else
                {
                    cur.Next = pointerB;
                    pointerB = pointerB.Next;
                }

                cur = cur.Next;
            }

            if (pointerA != null)
            {
                cur.Next = pointerA;
            }

            if (pointerB != null)
            {
                cur.Next = pointerB;
            }

            return dumpNode.Next;
        }

        private static LinkedListNode GetMiddleNodeOfList(LinkedListNode head)
        {
            var slow = head;
            var fast = head;

            while (fast != null && fast.Next != null && fast.Next.Next != null)
            {
                fast = fast.Next.Next;
                slow = slow.Next;
            }

            return slow;
        }
    }
}
