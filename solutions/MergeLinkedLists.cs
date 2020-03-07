using System;
using System.Collections.Generic;
namespace InterviewPreparation
{

    // Merge two sorted linked lists and return it as a new list. 
    // The new list should be made by splicing together the nodes
    // of the first two lists.
    public class MergeTwoListsSolution {
    public static ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        if (l1 == null)
            return l2;
        if (l2 == null)
            return l1;
        if (l1 == null & l2 == null)
            return null;
        ListNode runner = new ListNode(-1);
        ListNode result = runner;
        while(l1 != null || l2 != null)
        {
            if (l1 == null)
            {
                runner.next = new ListNode(l2.val);
                l2 = l2.next;
            }
            else if (l2 == null)
            {
                runner.next = new ListNode(l1.val);
                l1 = l1.next;
            }
            else if (l1.val <= l2.val)
            {
                runner.next = new ListNode(l1.val);
                l1 = l1.next;
            }
            else
            {
                runner.next = new ListNode(l2.val);
                l2 = l2.next;
            }
            runner = runner.next;
        }

        return result.next;
    }

    public static void ExecuteSolution()
    {
        var input1 = new ListNode(1);
        var head1 = input1;
        input1.next = new ListNode(2);
        input1 = input1.next;
        input1.next = new ListNode(4);

        var input2 = new ListNode(1);
        var head2 = input2;
        input2.next = new ListNode(3);
        input2 = input2.next;
        input2.next = new ListNode(4);


        var res = MergeTwoListsSolution.MergeTwoLists(head1, head2);
    }
}
//  public class ListNode {
//      public int val;
//      public ListNode next;
//      public ListNode(int x) { val = x; }
//  }

}