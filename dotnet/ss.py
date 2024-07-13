class Solution:
    def addTwoNumbers(self, l1: list[int], l2: list[int]) -> list[int]:
        num1 = int(''.join(map(str, l1[::-1])))
        num2 = int(''.join(map(str, l2[::-1])))
    
    
        sum = num1 + num2
        return [int(d) for d in str(sum)[::-1]]

obj = Solution()
l1 = [9,9,9,9,9,9,9]
l2 = [9,9,9,9]

print(obj.addTwoNumbers(l1, l2))
