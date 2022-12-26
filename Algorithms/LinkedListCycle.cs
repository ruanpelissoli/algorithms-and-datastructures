using AlgorithmsAndDataStructures.DataStructures;

namespace AlgorithmsAndDataStructures.Algorithms;

// https://leetcode.com/problems/linked-list-cycle/
// Hash Table
// Linked List
// Two Pointers
internal class LinkedListCycle : IAlgorithmSolver
{
    public void Solve()
    {
        Console.WriteLine(nameof(LinkedListCycle));

        var head = new ListNode(3);
        var node1 = new ListNode(2);
        var node2 = new ListNode(0);
        var node3 = new ListNode(-4);

        head.Next = node1;
        node1.Next = node2;
        node2.Next = node3;
        node3.Next = node1;

        Console.WriteLine(Solution(head));
        Console.WriteLine();
    }

    static bool Solution(ListNode head)
    {
        ListNode slow = head,
                 fast = head;

        while (fast is not null && fast.Next is not null)
        {
            slow = slow.Next!;
            fast = fast.Next.Next!;

            if (slow == fast)
                return true;
        }

        return false;
    }
}
