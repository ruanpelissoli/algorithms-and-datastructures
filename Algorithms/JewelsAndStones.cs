namespace AlgorithmsAndDataStructures.Algorithms;

// https://leetcode.com/problems/jewels-and-stones/description/
// Hash Table
// String
internal class JewelsAndStones : IAlgorithmSolver
{
    public void Solve()
    {
        Console.WriteLine(nameof(JewelsAndStones));
        Console.WriteLine(Solution("aA", "aAAbbbb"));
        Console.WriteLine();
    }

    static int Solution(string jewels, string stones)
    {
        int ans = 0;
        HashSet<char> jewelsSet = new(jewels.ToCharArray());

        foreach (var c in stones)
        {
            if (jewelsSet.Contains(c)) ans++;
        }

        return ans;
    }
}
