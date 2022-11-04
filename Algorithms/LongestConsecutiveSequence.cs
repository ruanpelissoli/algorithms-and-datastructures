namespace AlgorithmsAndDataStructures.Algorithms;

internal class LongestConsecutiveSequence : IAlgorithmSolver
{
    public void Solve()
    {
        Console.WriteLine(nameof(LongestConsecutiveSequence));
        Console.WriteLine(Solution(new int[] { 100, 4, 200, 1, 3, 2 }));
        Console.WriteLine();
    }

    public int Solution(int[] nums)
    {
        var set = new HashSet<int>(nums);
        var longest = 0;

        foreach (var num in nums)
        {
            if (!set.Contains(num - 1))
            {
                var currentNum = num;
                var currentStreak = 1;

                while (set.Contains(currentNum + 1))
                {
                    currentNum += 1;
                    currentStreak += 1;
                }

                longest = Math.Max(longest, currentStreak);
            }
        }

        return longest;
    }
}
