using System.Text;

namespace AlgorithmsAndDataStructures.Algorithms;

// https://leetcode.com/problems/make-the-string-great/description/
// Stack
// String
internal class MakeTheStringGreat : IAlgorithmSolver
{
    public void Solve()
    {
        Console.WriteLine(nameof(MakeTheStringGreat));
        Console.WriteLine(Solution("leEeetcode"));
        Console.WriteLine(Solution("Pp"));
        Console.WriteLine();
    }

    static string Solution(string s)
    {
        Stack<char> stack = new();

        foreach (char c in s)
        {
            if (stack.Any() && Math.Abs(stack.Peek() - c) == 32)
                stack.Pop();
            else
                stack.Push(c);
        }

        StringBuilder sb = new();

        while (stack.Count > 0)
        {
            sb.Insert(0, stack.Pop());
        }

        return sb.ToString();
    }
}
