namespace AlgorithmsAndDataStructures.Algorithms;

// https://leetcode.com/explore/interview/card/leetcodes-interview-crash-course-data-structures-and-algorithms/703/arraystrings/4592/
// Two-pointer example
// Reverse the array in-place O(1) extra memory
internal class ReverseString : IAlgorithmSolver
{
    public void Solve()
    {
        Console.WriteLine(nameof(ReverseString));
        Solution1("hello".ToCharArray());
        Solution2("Hannah".ToCharArray());
        Console.WriteLine();
    }

    static void Solution1(char[] s)
    {
        // Start a pointer j from the end
        int j = s.Length - 1;

        // The second pointer from the beginnig is the i of the for
        for (int i = 0; i < s.Length / 2; i++)
        {
            // Swap values at positions i and j
            (s[i], s[j]) = (s[j], s[i]);

            // Decrement j, since i will be incremented inside the for
            j--;
        }

        Console.WriteLine(string.Join("", s));
    }

    static void Solution2(char[] s)
    {
        // Start two-pointers: one from the beginning and the other from the end
        int i = 0,
            j = s.Length - 1;

        // While they dont encounter each other
        while (i < j)
        {
            // Swap values at positions i and j
            (s[i], s[j]) = (s[j], s[i]);

            // Increment i and decrement j
            i++;
            j--;
        }

        Console.WriteLine(string.Join("", s));
    }
}
