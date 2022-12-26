using AlgorithmsAndDataStructures.DataStructures;

namespace AlgorithmsAndDataStructures.Algorithms;

// https://leetcode.com/problems/middle-of-the-linked-list/description/
// Linked List
// Two Pointers
internal class MiddleOfTheLinkedList : IAlgorithmSolver
{
    public void Solve()
    {
        Console.WriteLine(nameof(MiddleOfTheLinkedList));

        var head = new ListNode(1);
        var node1 = new ListNode(2);
        var node2 = new ListNode(3);
        var node3 = new ListNode(4);
        var node4 = new ListNode(5);

        head.Next = node1;
        node1.Next = node2;
        node2.Next = node3;
        node3.Next = node4;

        Console.WriteLine(Solution(head));
        Console.WriteLine();
    }

    static ListNode Solution(ListNode head)
    {
        ListNode slow = head,
                 fast = head;

        while (fast is not null && fast.Next is not null)
        {
            slow = slow.Next!;
            fast = fast.Next.Next!;
        }

        return slow;
    }
}
