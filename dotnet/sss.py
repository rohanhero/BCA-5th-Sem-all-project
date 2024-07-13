class Solution:
    def lengthOfLongestSubstring(self, s: str) -> int:
        count = 0
        for i in range(len(s) - 1):
            if s[i] > s[i + 1]:
                continue
            else:
                count = count + 1
        return count


obj = Solution()
print(obj.lengthOfLongestSubstring("abcabcbb"))
