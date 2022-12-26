using System.Text;

namespace AlgorithmsAndDataStructures.Algorithms;

// https://leetcode.com/problems/backspace-string-compare/
// Stack
// String
internal class BackspaceStringCompare : IAlgorithmSolver
{
    public void Solve()
    {
        Console.WriteLine(nameof(BackspaceStringCompare));
        Console.WriteLine(Solution("ab##", "c#d#"));
        Console.WriteLine(Solution("y#fo##f", "y#f#o##f"));
        Console.WriteLine();
    }

    static bool Solution(string s, string t)
    {
        return DoBackspace(s) == DoBackspace(t);
    }

    static string DoBackspace(string s)
    {
        char backspace = '#';

        Stack<char> stack = new();
        StringBuilder sb = new();

        foreach (char c in s)
        {
            if (c != backspace)
                stack.Push(c);
            else if (stack.Any())
                stack.Pop();
        }

        while (stack.Count > 0)
            sb.Append(stack.Pop());

        return sb.ToString();
    }
}
