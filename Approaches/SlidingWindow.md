**[Sliding Window](https://leetcode.com/explore/interview/card/leetcodes-interview-crash-course-data-structures-and-algorithms/703/arraystrings/4502/)**

Like two pointers, sliding windows work the same with arrays and strings - the important thing is that they're iterables with ordered elements. For the sake of brevity, the first part of this article up until the examples will be focusing on arrays. However, all the logic is identical for strings. You can swap every instance of the word "array" with "string" and it will make sense.

Sliding window is another common approach to solving problems related to arrays. A sliding window is actually implemented using two-pointers! First, let's start by looking at the concept of a subarray. Given an array, a subarray is just a section of the array. The elements need to be contiguous and in order. For example, with the array [1, 2, 3, 4], the subarrays, grouped by length are:

[1], [2], [3], [4]
[1, 2], [2, 3], [3, 4]
[1, 2, 3], [2, 3, 4]
[1, 2, 3, 4]
A subarray can be defined by two indices, the start and end. For example, with [1, 2, 3, 4], the subarray [2, 3] has a starting index of 1 and an ending index of 2. Let's call the starting index the left bound and the ending index the right bound. Another name for subarray in this context is "window", which we will use from now on.

The idea behind the sliding window technique is to efficiently find the "best" window that fits some constraint. Usually, the problem description will define what makes a window "better" (shorter length, larger sum etc.) and the constraint. Imagine that a problem wanted the length of the longest subarray with a sum less than or equal to k for an array with positive numbers. In this case, the constraint is sum(window) <= k, and the longer the window, the better it is. The general algorithm behind sliding window is:

Define a pointer for the left and right bound that represents the current window, usually both of them starting at 0.
Iterate over the array with the right bound to "add" elements to the window.
Whenever the constraint is broken, in this example if the sum of the window exceeds k, then "remove" elements from the window by incrementing the left bound until the condition is satisfied again.
Here's some pseudocode illustrating the concept:

```function fn(arr):
    left = 0
    for right in [0, arr.length - 1]:
        Do some logic to "add" element at arr[right] to window

        while left < right AND condition from problem not met:
            Do some logic to "remove" element at arr[left] from window
            left++

        Do some logic to update the answer```

With our "sum less than k" example, we can use a variable curr that keeps track of the current sum of the window. That way, we know when the sum exceeds k. We can "add" elements by doing curr += arr[right] and "remove" elements by doing curr -= arr[left]. The data and logic needed to maintain a window will vary between problems.