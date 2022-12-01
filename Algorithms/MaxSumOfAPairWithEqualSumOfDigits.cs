namespace AlgorithmsAndDataStructures.Algorithms;

// https://leetcode.com/problems/max-sum-of-a-pair-with-equal-sum-of-digits/
// Array
// Hash Table
// Sorting
// Heap (Priority Queue)
internal class MaxSumOfAPairWithEqualSumOfDigits : IAlgorithmSolver
{
    public void Solve()
    {
        Console.WriteLine(nameof(MaxSumOfAPairWithEqualSumOfDigits));
        Console.WriteLine(Solution(new int[] { 18, 43, 36, 13, 7 }));
        Console.WriteLine(Solution(new int[] { 10, 12, 19, 14 }));
        Console.WriteLine();
    }

    static int Solution(int[] nums)
    {
        Dictionary<int, int> dict = new();
        var res = -1;

        foreach (var num in nums)
        {
            var key = DigitSum(num);

            if (!dict.ContainsKey(key))
                dict.Add(key, num);
            else
            {
                res = Math.Max(res, dict[key] + num);
                dict[key] = Math.Max(dict[key], num);
            }
        }

        return res;
    }

    static int DigitSum(int n)
    {
        var sum = 0;
        while (n != 0)
        {
            sum += n % 10;
            n /= 10;
        }

        return sum;
    }
}
