namespace AlgorithmsAndDataStructures.Algorithms;

// https://leetcode.com/problems/valid-parentheses/
// Stack
// String
internal class ValidParentheses : IAlgorithmSolver
{
    public void Solve()
    {
        Console.WriteLine(nameof(ValidParentheses));
        Console.WriteLine(Solution("()[]{}"));
        Console.WriteLine(Solution("(]"));
        Console.WriteLine();
    }

    static bool Solution(string s)
    {
        Dictionary<char, char> pairs = new()
        {
            { '(', ')' },
            { '{', '}' },
            { '[', ']' }
        };

        Stack<char> stack = new();

        foreach (char c in s)
        {
            if (pairs.ContainsKey(c))
                stack.Push(c);
            else
            {
                if (!stack.Any())
                    return false;

                char previousOpening = stack.Pop();

                if (pairs[previousOpening] != c)
                    return false;
            }
        }

        return !stack.Any();
    }

    static bool IsOpeningBracket(char c)
    {
        return new char[] { '(', '{', '[' }.Contains(c);
    }
}
