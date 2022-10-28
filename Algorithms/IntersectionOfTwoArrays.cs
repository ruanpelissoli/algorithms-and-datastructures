namespace AlgorithmsAndDataStructures.Algorithms;
internal class IntersectionOfTwoArrays : IAlgorithmSolver
{
    public void Solve()
    {
        Console.WriteLine(nameof(IntersectionOfTwoArrays));
        Console.WriteLine(string.Join(" ", Solution(
            new int[] { 4, 9, 5 }, new int[] { 9, 4, 9, 8, 4 })));
        Console.WriteLine();
    }

    static int[] Solution(int[] nums1, int[] nums2)
    {
        var n1 = new HashSet<int>(nums1);
        var n2 = new HashSet<int>(nums2);

        return n1.Intersect(n2).ToArray();
    }

    static int[] Solution2(int[] nums1, int[] nums2)
    {
        var set = new HashSet<int>(nums1);
        var res = new HashSet<int>();

        foreach (var num in nums2)
            if (set.Remove(num))
                res.Add(num);

        return res.ToArray();
    }
}
