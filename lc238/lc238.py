# Leetcode 238
# Product of Array Except Self
# Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].

from typing import List


def productExceptSelf(nums: List[int]) -> List[int]:
    res = [1] * (len(nums))     # creates an array with length of nums and each initial value being 1

    prefix = 1
    for i in range(len(nums)):
        res[i] = prefix
        prefix *= nums[i]
    postfix = 1
    for i in range(len(nums) - 1, - 1, - 1):    # range(start, stop, step)
        res[i] *= postfix
        postfix *= nums[i]
    
    return res

nums = [1,2,3,4]
print(productExceptSelf(nums))