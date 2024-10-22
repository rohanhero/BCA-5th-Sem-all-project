class Solution:
    def singleNumber(self, nums: list[int]) -> int:
        sortedarr = sorted(nums)

        res = []
        for i in range(len(sortedarr)):
            for j in range(i + 1, len(sortedarr)):
                if nums[i] == nums[j]:
                    res.append(nums[j])

        actualarr = []
        for i in range(len(sortedarr)):
            if sortedarr[i] in res:
                pass
            else:
                actualarr.append(sortedarr[i])

        for i in range(len(nums)):
            if nums[i] in actualarr:
                return nums[i]

obj = Solution()
print(obj.singleNumber([4, 1, 2, 1, 2, 5, 6, 8, 38, 55]))