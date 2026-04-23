class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        answear = {}
        for i,n in enumerate(nums):
            val = target - n
            if val in answear:
                return [answear[val], i]
            answear[n] = i