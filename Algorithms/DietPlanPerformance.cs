namespace AlgorithmsAndDataStructures.Algorithms;

// https://leetcode.com/problems/diet-plan-performance/
// Sliding Window
internal class DietPlanPerformance : IAlgorithmSolver
{
    public void Solve()
    {
        Console.WriteLine(nameof(DietPlanPerformance));
        Console.WriteLine(
            Solution(new int[] { 1, 2, 3, 4, 5 }, 1, 3, 3));
        Console.WriteLine(
            Solution(new int[] { 3, 2 }, 2, 0, 1));
        Console.WriteLine(
           Solution(new int[] { 6, 5, 0, 0 }, 2, 1, 5));
        Console.WriteLine();
    }

    static int Solution(int[] calories, int k, int lower, int upper)
    {
        int points = 0;

        int start = 0,
            end = k - 1;

        while (end < calories.Length)
        {
            var sum = 0;

            for (int i = start; i <= end; i++)
                sum += calories[i];

            if (sum > upper) points++;
            else if (sum < lower) points--;

            start++;
            end++;
        }

        return points;
    }
}
