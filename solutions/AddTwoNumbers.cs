using System;
using System.Collections.Generic;
namespace InterviewPreparation
{
    //You are given two non-empty linked lists representing two non-negative integers. The digits 
    // are stored in reverse order and each of their nodes contain a single digit. Add the two numbers 
    // and return it as a linked list.
    // You may assume the two numbers do not contain any leading zero, except the number 0 itself.

    // Example:
    // Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
    // Output: 7 -> 0 -> 8
    // Explanation: 342 + 465 = 807.
    public class AddTwoNumbersSolution 
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2) 
        {
            ListNode runner1 = l1;
            ListNode runner2 = l2;
            ListNode result;
            ListNode resultRunner;
            var previousPeriod = 0;
            result = new ListNode(0);
            resultRunner = result;
            while (runner1 != null || runner2 != null || previousPeriod == 1)
            {
                var resVal = (runner1 != null ? runner1.val : 0) + (runner2 != null ? runner2.val : 0) + previousPeriod;
                
                if (resVal >= 10) 
                {
                    resVal = resVal % 10;
                    previousPeriod = 1;
                }
                else
                    previousPeriod = 0;
                
                resultRunner.next = new ListNode(resVal);
                resultRunner = resultRunner.next;
                if (runner1 != null)
                    runner1 = runner1.next;
                if (runner2 != null)
                    runner2 = runner2.next;
            }

            return result.next;
        } 

        public static void ExecuteSolution()
        {
                        // var input1 = new ListNode(2);
            // var head1 = input1;
            // input1.next = new ListNode(4);
            // input1 = input1.next;
            // input1.next = new ListNode(3);

            // var input2 = new ListNode(5);
            // var head2 = input2;
            // input2.next = new ListNode(6);
            // input2 = input2.next;
            // input2.next = new ListNode(4);
            // var head2 = new ListNode(5);

            // var res = AddTwoNumbersSolution.AddTwoNumbers(null, head2);
        }  
    }

    public class ListNode 
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}