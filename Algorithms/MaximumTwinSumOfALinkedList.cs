using AlgorithmsAndDataStructures.DataStructures;

namespace AlgorithmsAndDataStructures.Algorithms;

// https://leetcode.com/problems/maximum-twin-sum-of-a-linked-list/
// Linked List
// Two Pointers
// Stack
internal class MaximumTwinSumOfALinkedList : IAlgorithmSolver
{
    public void Solve()
    {
        Console.WriteLine(nameof(MaximumTwinSumOfALinkedList));
        Console.WriteLine(Solution(ListNode.FromArray(new int[] { 5, 4, 2, 1 })).ToString());
        Console.WriteLine();
    }

    static int Solution(ListNode head)
    {
        // Setup fast and slow pointers
        ListNode slow = head,
                 fast = head;

        // Create a variable to hold middle index value
        int middleIndex = 0;

        // Move through the pointers until fast reaches the end,
        // When it does, slow pointer will be at the middle
        while (fast is not null && fast.Next is not null)
        {
            slow = slow.Next!;
            fast = fast.Next.Next!;
            middleIndex++;
        }

        // Reverse the last middle of the array passing the slow pointer to the reverse function
        // When it finishes, the last half of the linked list will be reversed
        ListNode middleHead = ReverseALinkedList.Reverse(slow);

        // Answer variable
        int ans = 0;

        // Now we move through an iteration until middleIndex
        for (int i = 0; i < middleIndex; i++)
        {
            ans = Math.Max(ans, head.Value + middleHead.Value);

            head = head.Next!;
            middleHead = middleHead.Next!;
        }

        // return answer
        return ans;
    }
}
