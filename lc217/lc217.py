from ast import While
from operator import truediv
from typing import List

def containsDuplicate(nums: List[int]) -> bool:
    l, r = 0, 1

    nums.sort()

    while r < len(nums):
        if nums[l] == nums[r]:
            return True
        else:
            l+=1
            r+=1
    return False

# nums = [1,2,3,4] return False
nums = [1,2,3,1]  # returns True
print(containsDuplicate(nums))