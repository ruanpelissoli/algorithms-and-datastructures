using AlgorithmsAndDataStructures.DataStructures;

namespace AlgorithmsAndDataStructures.Algorithms;

// https://leetcode.com/problems/remove-duplicates-from-sorted-list/

// Linked list is sorted
// delete all duplicates such that each element appears only once
internal class RemoveDuplicatesFromSortedList : IAlgorithmSolver
{
    public void Solve()
    {
        Console.WriteLine(nameof(RemoveDuplicatesFromSortedList));

        var node5 = new ListNode(3);
        var node4 = new ListNode(3, node5);
        var node3 = new ListNode(2, node4);
        var node2 = new ListNode(1, node3);
        var node1 = new ListNode(1, node2);

        Console.WriteLine(Solution(node1).ToString());
        Console.WriteLine();
    }

    // Time complexity: O(n). Because each node in the list is checked exactly once to determine if it is a duplicate or not, the total run time is O(n), where n is the number of nodes in the list.
    // Space complexity: O(1). No additional space is used.
    static ListNode Solution(ListNode head)
    {
        // Keep track if head in a current ListNode variable
        ListNode current = head;

        // Iterate while current and current.Next are not null
        while (current != null && current.Next != null)
        {
            // If current.Next.Value is equals to Current.Value
            if (current.Next.Value == current.Value)
                // Delete the current node pointing tho the next one
                current.Next = current.Next.Next;
            else
                // Else, go to the next node
                current = current.Next;
        }

        // return the head
        return head;
    }
}
