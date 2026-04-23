#include <string>
#include <cctype>

class Solution {
public:
    bool isPalindrome(std::string s) {
        int left = 0;
        int right = s.length() - 1;

        while (left < right) {
            // Ignorăm caracterele care nu sunt litere sau cifre din stânga
            while (left < right && !isalnum(s[left])) {
                left++;
            }
            // Ignorăm caracterele care nu sunt litere sau cifre din dreapta
            while (left < right && !isalnum(s[right])) {
                right--;
            }
            
            // Comparăm caracterele (le transformăm în litere mici pentru a fi case-insensitive)
            if (tolower(s[left]) != tolower(s[right])) {
                return false; // Dacă nu se potrivesc, clar nu e palindrom
            }
            
            // Mutăm pointerii mai departe
            left++;
            right--;
        }
        
        return true; // Dacă am ajuns la mijloc fără să găsim diferențe, e palindrom
    }
};