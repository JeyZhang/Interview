using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class ReverseList
    {
        public LinkedListNode Reverse(LinkedListNode head)
        {
            if (head == null || head.Next == null)
            {
                return head;
            }

            var cur = head;
            var next = head.Next;
            cur.Next = null; // break the first next link

            while (next != null)
            {
                var tmp = next.Next;
                next.Next = cur;
                cur = next;
                next = tmp;
            }

            return cur;
        }
    }
}
