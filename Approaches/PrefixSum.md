**[Prefix Sum](https://leetcode.com/explore/interview/card/leetcodes-interview-crash-course-data-structures-and-algorithms/703/arraystrings/4503/)**

A prefix sum is a technique that can be used with integer arrays. The idea is to create an array prefix where prefix[i] is the sum of all elements up to the index i (inclusive). For example, given nums = [5, 2, 1, 6, 3, 8], we would have prefix = [5, 7, 8, 14, 17, 25].

Prefix sums allow us to find the sum of any subarray in O(1)O(1). If we want the sum of the subarray from i to j (inclusive), then the answer is prefix[j] - prefix[i - 1], or prefix[j] - prefix[i] + nums[i] if you don't want to deal with the out of bounds case when i = 0.

Building a prefix sum is very simple. Here's some pseudocode:

```Given an integer array nums,

prefix = [nums[0]]
for i in [1, len(nums) - 1]:
    prefix.append(nums[i] + prefix[prefix.length - 1])```