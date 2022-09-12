#LC 1

from typing import List

def twoSum(nums: List[int], target: int) -> List[int]:
    prevMap = {} # value : index

    for i, n in enumerate(nums):
        diff = target - n
        if diff in prevMap:
            return[prevMap[diff], i]
        prevMap[n] = i
    return 

numbers = [2,7,11,15]
target = 9
print(twoSum(numbers, target))

""" This solution uses a hashmap and subtraction from the target to find the solution. 
    Using the list of numbers it will subtract that number from the target, check if in the hashmap and place in the hashmap if not there.
    If the number is in the hashmap it will then use the current number and the one in the hashmap which is be the solutions
    Example:  
        List = [2,1,5,3]
        Target = 4

        If Not in Hashmap places the value and index in as number in list and index.

        4-2 = 2    Index 0: Not in Hashmap. 2:0
        4-1 = 1    Index 1: Not in Hashmap. 1:1
        4-5 = -1   Index 2: Not in Hashmap. 5:2
        4-3 = 1    Index 3: IN HASHMAP as 1:1

        The value from the current calculation is 1 so we know then the value from that index in the hashmap is 1 and the current value being used is 3
        3 + 1 = 4 which is out target

        Return the 2 indexes which are 1 and 3 where the values of these index's equal the target of 4
"""