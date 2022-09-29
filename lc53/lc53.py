# Leetcode 53
# Maximum Subarray
# Sliding windows, removing negative prefix

from typing import List

def maxSubArray(nums: List[int]) -> int:
    maxSub = nums[0]
    curSum = 0

    for n in nums:
        if curSum < 0:
            curSum = 0
        curSum += n
        maxSub = max(maxSub, curSum)

    return maxSub

nums = [-2,1,-3,4,-1,2,1,-5,4]
print(maxSubArray(nums))

