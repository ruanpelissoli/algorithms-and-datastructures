using AlgorithmsAndDataStructures.DataStructures;

namespace AlgorithmsAndDataStructures.Algorithms;

// https://leetcode.com/problems/range-sum-of-bst/
// Tree
// Depth-First Search
// Binary Search Tree
// Search Tree
// Easy

internal class RangeSumOfBST : IAlgorithmSolver
{
    public void Solve()
    {
        Console.WriteLine(nameof(RangeSumOfBST));

        var node3 = new TreeNode(3);
        var node4 = new TreeNode(7);

        var node5 = new TreeNode(18);

        var node1 = new TreeNode(5, node3, node4);
        var node2 = new TreeNode(15, right: node5);

        var root = new TreeNode(10, node1, node2);

        Console.WriteLine(Solution(root, 7, 15));
        Console.WriteLine();
    }

    // Recursion
    static int Solution(TreeNode root, int low, int high)
    {
        var ans = 0;
        DepthFirstSearch(root, low, high, ref ans);

        return ans;
    }

    static int DepthFirstSearch(TreeNode node, int low, int high, ref int ans)
    {
        if (node == null) return ans;

        if (low <= node.Val && node.Val <= high)
            ans += node.Val;

        if (low < node.Val)
            DepthFirstSearch(node.Left, low, high, ref ans);

        if (node.Val < high)
            DepthFirstSearch(node.Right, low, high, ref ans);

        return ans;
    }

    // Iteration (Queue)
    static int Solution2(TreeNode root, int low, int high)
    {
        var ans = 0;

        if (root == null) return ans;

        Queue<TreeNode> nodes = new();
        TreeNode current;

        nodes.Enqueue(root);

        while (nodes.Count > 0)
        {
            current = nodes.Dequeue();

            if (current.Val >= low && current.Val <= high)
                ans += current.Val;

            if (current.Val > low && current.Left != null)
                nodes.Enqueue(current.Left);

            if (current.Val < high && current.Right != null)
                nodes.Enqueue(current.Right);
        }

        return ans;
    }
}
