// Leetcode 53
// Maximum Subarray
// O(n)

using System;

static int MaxSubArray(int[] nums) {
    int maxSub = nums[0];
    int curSum = 0;

    for (int i = 0; i < nums.Length; i++)
    {
        if (curSum < 0)
        {
            curSum = 0;
        }
        curSum += nums[i];
        maxSub = Math.Max(maxSub, curSum);
    }

    return maxSub;
}

int[] nums = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
Console.WriteLine(MaxSubArray(nums));