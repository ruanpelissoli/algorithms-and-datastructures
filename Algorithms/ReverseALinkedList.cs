using AlgorithmsAndDataStructures.DataStructures;

namespace AlgorithmsAndDataStructures.Algorithms;

internal class ReverseALinkedList : IAlgorithmSolver
{
    public void Solve()
    {
        Console.WriteLine(nameof(ReverseALinkedList));
        Console.WriteLine(Reverse(ListNode.FromArray(new int[] { 1, 2, 3, 4, 5 })).ToString());
        Console.WriteLine();
    }

    public static ListNode Reverse(ListNode head)
    {
        ListNode prev = null!;
        ListNode curr = head;

        while (curr != null)
        {
            var nextNode = curr.Next;
            curr.Next = prev;
            prev = curr;
            curr = nextNode!;
        }

        return prev;
    }
}
