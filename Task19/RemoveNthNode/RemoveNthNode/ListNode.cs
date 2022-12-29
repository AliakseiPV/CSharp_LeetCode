using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNthNode
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var result = head;

            var previous = result;
            var current = head;
            var last = head;

            while (n > 1)
            {
                last = last.next;
                n--;
            }

            while (last.next != null)
            {
                previous = current;
                current = current.next;
                last = last.next;
            }

            previous.next = current.next;
            current.next = null;

            return result;
        }
    }
}
