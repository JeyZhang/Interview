using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class MergeList
    {
        public static LinkedListNode Merge(LinkedListNode nodeA, LinkedListNode nodeB)
        {
            if (nodeA == null)
            {
                return nodeB;
            }

            if (nodeB == null)
            {
                return nodeA;
            }

            var tmp = new LinkedListNode(){ Value = 0 };
            var cur = tmp;

            var pointerA = nodeA;
            var pointerB = nodeB;

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

            return tmp.Next;
        }
    }
}
