using AlgorithmsAndDataStructures.DataStructures;

namespace AlgorithmsAndDataStructures.Algorithms;

// https://leetcode.com/problems/reverse-linked-list-ii/solutions/
// Linked List
internal class ReverseALinkedListII : IAlgorithmSolver
{
    public void Solve()
    {
        Console.WriteLine(nameof(ReverseALinkedListII));
        Console.WriteLine(Solution(ListNode.FromArray(new int[] { 1, 2, 3, 4, 5 }),
            2, 4).ToString());
        Console.WriteLine();
    }

    static ListNode Solution(ListNode head, int left, int right)
    {
        ListNode curr = head,
                 prev = null!;

        while (left > 1)
        {
            prev = curr!;
            curr = curr.Next!;

            left--;
            right--;
        }

        ListNode con = prev,
                 tail = curr;

        while (right > 0)
        {
            ListNode third = curr.Next!;
            curr.Next = prev;
            prev = curr;
            curr = third;
            right--;
        }

        if (con != null)
            con.Next = prev;
        else
            head = prev;

        tail.Next = curr;
        return head;
    }
}
