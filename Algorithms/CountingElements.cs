namespace AlgorithmsAndDataStructures.Algorithms;

// https://leetcode.com/problems/counting-elements/
// Hashtable
// Counting
internal class CountingElements : IAlgorithmSolver
{
    public void Solve()
    {
        Console.WriteLine(nameof(CountingElements));
        Console.WriteLine(Solution(new int[] { 1, 2, 3 })); // Output: 2
        Console.WriteLine(Solution(new int[] { 1, 1, 3, 3, 5, 5, 7, 7 })); // Output: 0
        Console.WriteLine();
    }

    static int Solution(int[] arr)
    {
        int count = 0;
        var set = new HashSet<int>(arr);

        for (int i = 0; i < arr.Length; i++)
        {
            if (set.Contains(arr[i] + 1)) count++;
        }

        return count;
    }
}
