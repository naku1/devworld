using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview
{
    public class ReverseSubList
    {
        public ListNode CreateLL()
        {
            ListNode Head = new ListNode { Value = 10, Next = null };
            Head.Next = new ListNode { Value = 20, Next = null };
            Head.Next.Next = new ListNode { Value = 30, Next = null };
            Head.Next.Next.Next = new ListNode { Value = 40, Next = null };
            Head.Next.Next.Next.Next = new ListNode { Value = 50, Next = null };
            Head.Next.Next.Next.Next.Next = new ListNode { Value = 60, Next = null };
            Head.Next.Next.Next.Next.Next.Next = new ListNode { Value = 70, Next = null };
            Head.Next.Next.Next.Next.Next.Next.Next = new ListNode { Value = 80, Next = null };

            return Head;
        }

        public void PrintLL(ListNode head)
        {
            while (head != null)
            {
                Console.Write(head.Value + " ");
                head = head.Next;
            }
        }

        public ListNode ReverseSubListFunction(ListNode head, int start, int end)
        {
            if (head == null || head.Next == null || start >= end)
            {
                return head;
            }

            ListNode previous = null;
            ListNode current = head;

            for (int i = 0; i < start && current != null; i++)
            {
                previous = current;
                current = current.Next;
            }

            ListNode beforeStart = previous;
            ListNode lastNodeInSub = current;
            ListNode next = null;
            previous = null;

            for (int i = start; i <= end && current != null; i++)
            {
                next = current.Next;
                current.Next = previous;
                previous = current;
                current = next;
            }
            
            beforeStart.Next = previous;
            lastNodeInSub.Next = current;

            return head;
        }
    }

    public class ListNode
    {
        public int Value { get; set; }
        public ListNode Next { get; set; }
    }
}
