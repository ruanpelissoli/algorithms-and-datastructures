using System.Text;

namespace AlgorithmsAndDataStructures.Algorithms;

// https://leetcode.com/problems/remove-all-adjacent-duplicates-in-string/
// Stack
// String
internal class RemoveAllAdjacentDuplicatesInString : IAlgorithmSolver
{
    public void Solve()
    {
        Console.WriteLine(nameof(RemoveAllAdjacentDuplicatesInString));
        Console.WriteLine(Solution("abbaca"));
        Console.WriteLine();
    }

    static string Solution(string s)
    {
        Stack<char> stack = new();

        foreach (char c in s)
        {
            if (stack.Any() && stack.Peek() == c)
                stack.Pop();
            else
                stack.Push(c);
        }

        StringBuilder sb = new();

        while (stack.Any())
            sb.Append(stack.Pop());

        return new string(sb.ToString().Reverse().ToArray());
    }
}
