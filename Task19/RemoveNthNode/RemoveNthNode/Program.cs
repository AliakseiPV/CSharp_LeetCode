using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNthNode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListNode listNode = new ListNode(1);
            listNode.next = new ListNode(2);
            listNode.next.next = new ListNode(3);
            listNode.next.next.next = new ListNode(4);
            listNode.next.next.next.next = new ListNode(5);

            var a = listNode.RemoveNthFromEnd(listNode, 2);
        }
    }
}
