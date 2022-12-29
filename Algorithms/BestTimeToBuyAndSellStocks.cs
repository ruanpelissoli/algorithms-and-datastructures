namespace AlgorithmsAndDataStructures.Algorithms;

// https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
// Sliding Window
// Dynamic Programming
internal class BestTimeToBuyAndSellStocks : IAlgorithmSolver
{
    public void Solve()
    {
        Console.WriteLine(nameof(BestTimeToBuyAndSellStocks));
        Console.WriteLine(Solution(new int[] { 7, 1, 5, 3, 6, }));
        Console.WriteLine(Solution(new int[] { 7, 6, 4, 3, 1, }));
        Console.WriteLine();
    }

    static int Solution(int[] prices)
    {
        int ans = 0;
        int i = 0, j = 1;

        while (j < prices.Length)
        {
            if (prices[j] > prices[i])
                ans = Math.Max(ans, prices[j] - prices[i]);
            else
                i = j;

            j++;
        }

        return ans;
    }
}
