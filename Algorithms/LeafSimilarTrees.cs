using AlgorithmsAndDataStructures.DataStructures;

namespace AlgorithmsAndDataStructures.Algorithms;

// https://leetcode.com/problems/leaf-similar-trees/
// Tree
// Depth-First Search
// Binary Tree
internal class LeafSimilarTrees : IAlgorithmSolver
{
    public void Solve()
    {
        Console.WriteLine(nameof(LeafSimilarTrees));
        Console.WriteLine();
        Console.WriteLine();
    }

    static bool Solution(TreeNode root1, TreeNode root2)
    {
        IList<int> tree1 = FindLeaves(root1);
        IList<int> tree2 = FindLeaves(root2);

        if (tree1.Count != tree2.Count)
            return false;

        for (int i = 0; i < tree1.Count; i++)
        {
            if (tree1[i] != tree2[i])
                return false;
        }

        return true;
    }

    static IList<int> FindLeaves(TreeNode root)
    {
        List<int> leaves = new();
        System.Collections.Generic.Stack<TreeNode> stack = new();
        stack.Push(root);

        while (stack.Count > 0)
        {
            TreeNode node = stack.Pop();
            if (node.Right == null && node.Left == null)
                leaves.Add(node.Val);

            if (node.Right != null)
                stack.Push(node.Right);

            if (node.Left != null)
                stack.Push(node.Left);
        }

        return leaves;
    }
}
