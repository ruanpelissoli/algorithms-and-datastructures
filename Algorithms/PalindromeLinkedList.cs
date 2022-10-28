using AlgorithmsAndDataStructures.DataStructures;

namespace AlgorithmsAndDataStructures.Algorithms;

internal class PalindromeLinkedList : IAlgorithmSolver
{
    public void Solve()
    {
        var node4 = new ListNode(1);
        var node3 = new ListNode(2, node4);
        var node2 = new ListNode(2, node3);
        var node1 = new ListNode(1, node2);

        Console.WriteLine(nameof(PalindromeLinkedList));
        Console.WriteLine(Solution(node1));
        Console.WriteLine();
    }

    static bool Solution(ListNode head)
    {
        var values = new List<int>();

        var curr = head;
        while (curr != null)
        {
            values.Add(curr.Value);
            curr = curr.Next;
        }

        int end = values.Count - 1;
        for (int start = 0; start < values.Count / 2; start++)
        {
            if (values[start] != values[end]) return false;
            end--;
        }

        return true;
    }
}
