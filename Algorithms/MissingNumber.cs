namespace AlgorithmsAndDataStructures.Algorithms;
internal class MissingNumber : IAlgorithmSolver
{
    public void Solve()
    {
        Console.WriteLine(nameof(MissingNumber));
        Console.WriteLine(Solution(new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 }));
        Console.WriteLine();
    }

    static int Solution(int[] nums)
    {
        var set = new HashSet<int>(nums);

        int expectedCount = nums.Length + 1;
        for (int number = 0; number < expectedCount; number++)
        {
            if (!set.Contains(number)) return number;
        }

        return -1;
    }
}
