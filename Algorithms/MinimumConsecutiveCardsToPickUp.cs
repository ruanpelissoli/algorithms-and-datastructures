namespace AlgorithmsAndDataStructures.Algorithms;

// https://leetcode.com/problems/minimum-consecutive-cards-to-pick-up/
// Array
// Hash Table
// Sliding Window
internal class MinimumConsecutiveCardsToPickUp : IAlgorithmSolver
{
    public void Solve()
    {
        Console.WriteLine(nameof(MinimumConsecutiveCardsToPickUp));
        Console.WriteLine(Solution(new int[] { 3, 4, 2, 3, 4, 7 }));
        Console.WriteLine();
    }

    static int Solution(int[] cards)
    {
        Dictionary<int, List<int>> count = new();

        for (int i = 0; i < cards.Length; i++)
        {
            if (!count.ContainsKey(cards[i]))
                count.Add(cards[i], new List<int>());

            count[cards[i]].Add(i);
        }

        int min = int.MaxValue;

        foreach (var kvp in count)
        {
            var arr = kvp.Value;

            for (int i = 0; i < arr.Count - 1; i++)
                min = Math.Min(min, arr[i + 1] - arr[i] + 1);
        }

        if (min == int.MaxValue) return -1;

        return min;
    }
}
