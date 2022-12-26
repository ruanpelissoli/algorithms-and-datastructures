using AlgorithmsAndDataStructures.DataStructures;

namespace AlgorithmsAndDataStructures.Algorithms;
internal class SwapNodesInPairs : IAlgorithmSolver
{
    public void Solve()
    {
        Console.WriteLine(nameof(SwapNodesInPairs));
        Console.WriteLine(Solution(ListNode.FromArray(new int[] { 1, 2, 3, 4 })).ToString());
        Console.WriteLine();
    }

    static ListNode Solution(ListNode head)
    {
        if (head is null || head.Next is null)
            return head!;

        ListNode dummy = head.Next;
        ListNode prev = null!;

        while (head != null && head.Next != null)
        {
            if (prev != null)
                prev.Next = head.Next;

            prev = head;

            ListNode nextNode = head.Next.Next!;
            head.Next.Next = head;

            head.Next = nextNode;
            head = nextNode!;
        }

        return dummy;
    }
}
