namespace AlgorithmsAndDataStructures.Algorithms;

// https://leetcode.com/problems/product-of-array-except-self/ 
// Array
// Prefix Sum
internal class ProductOfArrayExceptSelf : IAlgorithmSolver
{
    public void Solve()
    {
        Console.WriteLine(nameof(ProductOfArrayExceptSelf));
        Console.WriteLine(Solution(new int[] { 1, 2, 3, 4 }));
        Console.WriteLine();
    }

    static int[] Solution(int[] nums)
    {
        var answer = new int[nums.Length];

        int prefix = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            answer[i] = prefix;
            prefix *= nums[i];
        }

        int postfix = 1;
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            answer[i] *= postfix;
            postfix *= nums[i];
        }

        return answer;
    }
}
