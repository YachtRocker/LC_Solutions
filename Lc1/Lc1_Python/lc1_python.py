class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        for i in nums:
            test = nums.copy()
            test.remove(i)
            for num in test:
                if i + num == target:
                    one = nums.index(i)
                    two = nums.index(num)
                    if one == two:
                        return [i for i,x in enumerate(nums) if x==num]
                    else:
                        return [one, two]