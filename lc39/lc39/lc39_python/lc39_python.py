# O(n) = 2^n
# Leetcode 39 - Combination Sum

from typing import List


def combinationSum(self, candidates: List[int], target: int) -> List[List[int]]:
    result = []

    def dfs(i, cur: List[int], total):
        if total == target:  # base case if we succeed
            result.append(cur.copy())
            return
        if i >= len(candidates) or total > target:  # base case if cannot find candidates that = target
            return
       
        cur.append(candidates[i])
        dfs(i, cur, total + candidates[i])  # Left side of the decision tree
        cur.pop()
        dfs(i + 1, cur, total)  # Right side of the decision tree

    dfs(0, [], 0)
    return result

candidates = [2,3,5]
target = 8
print(combinationSum(0, candidates, target ))


