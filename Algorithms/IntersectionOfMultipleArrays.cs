namespace AlgorithmsAndDataStructures.Algorithms;

// https://leetcode.com/problems/intersection-of-multiple-arrays/
// Hashtable
// Counting
internal class IntersectionOfMultipleArrays : IAlgorithmSolver
{
    public void Solve()
    {
        Console.WriteLine(nameof(IntersectionOfMultipleArrays));
        Console.WriteLine(Solution(new int[][]
            {
                new int [] { 3, 1, 2, 4, 5 },
                new int [] { 1, 2, 3, 4 },
                new int [] { 3, 4, 5, 6 }
            }));
        Console.WriteLine();
    }

    static List<int> Solution(int[][] nums)
    {
        var ans = new List<int>();
        var count = new Dictionary<int, int>();

        foreach (var i in nums)
            foreach (var j in i)
            {
                if (!count.ContainsKey(j))
                    count.Add(j, 1);
                else
                    count[j]++;

                if (count[j] == nums.Length) ans.Add(j);
            }

        ans.Sort();

        return ans;
    }
}
