using System.Text;

namespace AlgorithmsAndDataStructures.Algorithms;
internal class MinimumRemoveToMakeValidParentheses : IAlgorithmSolver
{
    public void Solve()
    {
        Console.WriteLine(nameof(MinimumRemoveToMakeValidParentheses));
        Console.WriteLine(Solution("lee(t(c)o)de)"));
        Console.WriteLine();
    }

    static string Solution(string s)
    {
        // HashSet to save the indexes where there is an invalid parenthesis
        HashSet<int> indexesToRemove = new();

        // Stack to keep track of all the parenthesis
        Stack<int> stack = new();

        // We'll iterate through all the char in the given string
        for (int i = 0; i < s.Length; i++)
        {
            // If it is an open parenthesis, add to the stack
            if (s[i] == '(')
                stack.Push(i);
            else if (s[i] == ')')
            {
                // If it is a closing parenthesis and the stack count is zero, add to indexesToRemove hashset,
                // because it means that this parenthesis does not have a pair and should be removed
                if (stack.Count is 0)
                    indexesToRemove.Add(i);
                else
                    // If stack count is not zero, means it have a pair, so we pop it
                    stack.Pop();
            }
        }

        // While the stack still contais parenthesis, pop it inside the indexes to remove hashset
        // to make sure we did not leave anything behind
        while (stack.Any())
            indexesToRemove.Add(stack.Pop());

        // For last, we create a string build to create the new valid string
        StringBuilder sb = new();
        for (int i = 0; i < s.Length; i++)
        {
            // And only append the indexes that are not contained in the indexesToRemove set
            if (!indexesToRemove.Contains(i))
                sb.Append(s[i]);
        }

        return sb.ToString();
    }
}
