namespace AlgorithmsAndDataStructures.DataStructures;

internal class TreeNode
{
    public int Val;
    public TreeNode Left;
    public TreeNode Right;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        Val = val;
        Left = left;
        Right = right;
    }

    public TreeNode FromArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Insert(i);
        }

        return this;
    }

    public void Insert(int value)
    {
        if (value < Val)
        {
            if (Left == null) Left = new TreeNode(value);
            else Left.Insert(value);
        }
        else
        {
            if (Right == null) Right = new TreeNode(value);
            else Right.Insert(value);
        }
    }
}
