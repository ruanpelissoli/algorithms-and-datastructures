**[Hashing](https://leetcode.com/explore/interview/card/leetcodes-interview-crash-course-data-structures-and-algorithms/705/hashing/4510/)**

In this chapter, we are going to talk about hash maps and sets, which are implemented using hashing.

A hash function is a function that takes any input and deterministically converts it to an integer that is less than a fixed size set by the programmer. Inputs are called keys and the same input will always be converted to the same integer. Here's an example hash algorithm for a string containing letters of the English alphabet:

Declare an integer total.
Iterate over the string. For each character, convert it to its position in the alphabet. For example, a -> 1, c -> 3, z -> 26.
Take that value, and multiply it by the current position in the string (index + 1). For example, given the string "abc", the b is at position 2 in the alphabet and position 2 in the string, so we get the final value 2 * 2 = 4. Add this to total.
After going through every character, total is the converted value.
This algorithm isn't actually a good hash function (we'll talk about what makes a hash function "good" soon) but is an example of how to convert strings into integers. You may be wondering: don't we need to limit total to a fixed size? Correct! Right now, this algorithm is wrong. Let's say the limit we set was x. Then change step 4 to:

After going through every character, total % x is the converted value.
% is the modulo operation, and makes sure the final converted value will always be less than x.

What is the point of a hash function?
We know that arrays have O(1) random access. The main constraint with arrays is that they are a fixed size, and their indices have to be integers. Because hash functions can convert any input into an integer, if we combine an array with a hash function, we can create what is known as a hash map, also known as a hash table or dictionary. Then, we can essentially have the O(1) random access of an array without the constraint of integers as indices. With arrays, we map indices to values. With hash maps, we map keys to values, and a key can be almost anything. The only constraint on a hash map's key is that it has to be immutable. Values can be anything.

A hash map is probably the most important concept in all of algorithm interviewing. It is extremely powerful and allows you to reduce the time complexity of an algorithm by a factor of O(n) for a huge amount of problems. Every major language has a built-in implementation of a hash map. For example, in Python they're called dictionaries and declaring one is as simple as dic = {}. If you could only take one thing from this course, it should be to memorize and master the hash map operations for the programming language you use.

To summarize, a hash map is an unordered data structure that stores key-value pairs. A hash map can add and remove elements in O(1), as well as update values associated with a key and check if a key exists, also in O(1). You can iterate over both the keys and values of a hash map, but a hash map isn't necessarily an ordered data structure (there are many implementations and this is language dependent for the built-in types).

An ordered data structure is one where the insertion order is "remembered". An unordered data structure is one where the insertion order is not relevant.

Comparison with arrays
In terms of time complexity, hash maps blow arrays out of the water. The following operations are all O(1) for a hash map:

Add an element and associate it with a value
Delete an element if it exists
Check if an element exists
A hash map also has many of the same useful properties as an array with the same time complexity:

Find length/number of elements
Updating values
Iterate over elements
Hash maps are also just easier/cleaner to work with. Even if your keys are integers and you could get away with using an array, if you don't know what the max size of your key is, then you don't know how large you should size your array. With hash maps, you don't need to worry about that, since your key can be anything.

However, from a practical perspective, there are some disadvantages to using hash maps, and it's important to know them as it is common in interviews to talk about tradeoffs.

The biggest disadvantage of hash maps is that for smaller input sizes, they can be slower because of overhead. Because big O ignores constants, the O(1) time complexity can sometimes be deceiving - it's usually something more like O(10) because every key needs to go through the hash function, and there can also be collisions, which we will talk about in the next section.

When talking about the time complexity of hash map operations, they are constant relative to the size of the hash map. However, some keys can be very expensive to hash. For example, it may take O(m) time to hash a string, where mm is the length of the string. If you want to store a huge string as a key, then the time complexity can be deceiving.

Hash tables can also take up more space. Recall that dynamic arrays are actually fixed-size arrays that resize themselves when they go beyond their capacity. Hash tables are also implemented using a fixed size array - remember that the size is a limit set by the programmer. The problem is, resizing a hash table is much more expensive because every existing key needs to be re-hashed, and also a hash table may use an array that is significantly larger than the number of elements stored, resulting in a huge waste of space. Let's say you chose your limit as 10,000 items, but you only end up storing 10. Okay, you could argue that 10,000 is too large, but then what if your next test case ends up needing to store 100,000 elements? The point is, when you don't know how many elements you need to store, arrays are more flexible with resizing and not wasting space.