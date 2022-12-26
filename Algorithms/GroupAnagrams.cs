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
        // We will use a Dictionary of string with a string list value to store anagrams
        Dictionary<string, List<string>> words = new();

        foreach (string str in strs)
        {
            // Sort the current string of the iteration to use as key
            var sortedWord = new string(str.OrderBy(c => c).ToArray());

            // If this sorted key do not exist in the dict yet, add with a list of string as value
            if (!words.ContainsKey(sortedWord))
                words.Add(sortedWord, new List<string>());

            // Then add the current str to the list using the sortedWord key
            words[sortedWord].Add(str);
        }

        // Return a list of lists with the dict.Values
        return new List<IList<string>>(words.Values);
    }
}
