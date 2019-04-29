using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedListUtil
    {
        public static void PrintList(LinkedListNode head)
        {
            var list = new List<int>();
            while (head != null)
            {
                list.Add(head.Value);
                head = head.Next;
            }
            Console.WriteLine(string.Join(", ", list));
        }
    }
}
