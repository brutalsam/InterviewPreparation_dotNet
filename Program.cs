using System;

namespace InterviewPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // InterviewPreparation.printSecondMinimum(new int[] { 10, 3, 2, 1, 1, 2, 3 });
            // InterviewPreparation.printSecondMinimum(new int[] { 1, 1, 1, 1, 1, 1, 1 });
            // Console.WriteLine(String.Join(", ", TwoSumSolution.TwoSum(new int[] {2,7,11,15}, 9)));
            // Console.WriteLine(String.Join(", ", TwoSumSolution.TwoSum(new int[] {2,6,11,15}, 13)));
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
            var head2 = new ListNode(5);

            var res = AddTwoNumbersSolution.AddTwoNumbers(null, head2);
        }
    }
}
