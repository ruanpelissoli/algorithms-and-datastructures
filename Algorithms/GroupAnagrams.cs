namespace AlgorithmsAndDataStructures.Algorithms;

// https://leetcode.com/problems/group-anagrams/
// Array
// Hashtable
// String
// Sorting
internal class GroupAnagrams : IAlgorithmSolver
{
    public void Solve()
    {
        Console.WriteLine(nameof(GroupAnagrams));
        Solution(new string[] { "eat", "tea", "tan", "ate", "nat", "bat" });
        Console.WriteLine();
    }

    static IList<IList<string>> Solution(string[] strs)
    {
        Dictionary<string, List<string>> words = new();

        foreach (string str in strs)
        {
            var sortedWord = new string(str.OrderBy(c => c).ToArray());

            if (!words.ContainsKey(sortedWord))
                words.Add(sortedWord, new List<string>());

            words[sortedWord].Add(str);
        }

        return new List<IList<string>>(words.Values);
    }
}
