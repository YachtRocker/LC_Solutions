// Leetcode 238
// Product of Array Except Self
// Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].

using System;

static int[] ProductExceptSelf(int[] nums) {
    int element = 1;
    int count = nums.Length;
    int prefix = 1;
    int postfix = 1;
    
    int[] res = new int[count];
    Array.Fill(res, element);  // Fills res array with all 1's

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = prefix;
        prefix *= nums[i];
    }

    for (int i = nums.Length; i -- > 0; )
    {
        res[i] *= postfix;
        postfix *= nums[i];
    }

    return res;
}

int[] nums = { 1, 2, 3, 4 };

int[] result = ProductExceptSelf(nums);

Console.WriteLine(string.Join(", ", result));