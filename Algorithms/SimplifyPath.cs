using System.Text;

namespace AlgorithmsAndDataStructures.Algorithms;

// https://leetcode.com/problems/simplify-path/description/
// Stack
// String
internal class SimplifyPath : IAlgorithmSolver
{
    public void Solve()
    {
        Console.WriteLine(nameof(SimplifyPath));
        Console.WriteLine(Solution("/home//foo/"));
        Console.WriteLine(Solution("/../"));
        Console.WriteLine();
    }

    static string Solution(string path)
    {
        Stack<string> stack = new();
        StringBuilder sb = new();

        var splitted = path.Split('/');

        foreach (string c in splitted)
        {
            if (string.IsNullOrWhiteSpace(c) || c == ".")
                continue;
            else if (c == "..")
            {
                if (stack.Count > 0)
                    stack.Pop();
            }
            else
                stack.Push(c);
        }

        while (stack.Count > 0)
        {
            var dir = stack.Pop();
            sb.Insert(0, dir);
            sb.Insert(0, "/");
        }

        return sb.Length > 0 ? sb.ToString() : "/";
    }
}

