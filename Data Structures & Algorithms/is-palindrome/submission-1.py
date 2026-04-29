class Solution:
    def isPalindrome(self, s: str) -> bool:
        dreapta = len(s) - 1
        stanga = 0

        while stanga < dreapta:
            while stanga < dreapta and not s[stanga].isalnum():
                stanga +=1
            
            while stanga < dreapta and not s[dreapta].isalnum():
                dreapta -=1

            if s[stanga].lower() != s[dreapta].lower():
                return False

            stanga +=1
            dreapta -=1
        return True
            
