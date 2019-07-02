using System;

namespace Addtwonumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ListNode number1 = new ListNode(2);
            ListNode number2 = new ListNode(5);
            number1.next= new ListNode(4);
            number2.next = new ListNode(6);
            number1.next.next = new ListNode(3);
            number2.next.next = new ListNode(4);
            ListNode number3 = addTwoNumbers(number1, number2);
            Console.WriteLine("Job Complete");
        }
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }


        static ListNode addTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode dummyHead = new ListNode(0);
            ListNode p = l1, q = l2, curr = dummyHead;
            int carry = 0;
            while (p != null || q != null)
            {
                int x = (p != null) ? p.val : 0;
                int y = (q != null) ? q.val : 0;
                int sum = carry + x + y;
                carry = sum / 10;
                curr.next = new ListNode(sum % 10);
                curr = curr.next;
                if (p != null) p = p.next;
                if (q != null) q = q.next;
            }
            if (carry > 0)
            {
                curr.next = new ListNode(carry);
            }
            return dummyHead.next;
        }
    }
}
