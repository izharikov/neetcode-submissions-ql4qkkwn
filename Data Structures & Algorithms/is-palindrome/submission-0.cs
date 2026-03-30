public class Solution {
    static bool IsValid(char c){
        return (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || (c >= '0' && c <= '9');
    }

    public bool IsPalindrome(string s) {
        if (s.Length <= 1) {
            return true;
        }
        var left = 0;
        var right = s.Length - 1;
        for (;left < right;) {
            while (!IsValid(s[left]) && left < right) {
                left++;
            }
            while (!IsValid(s[right]) && left < right) {
                right--;
            }
            if (Char.ToLower(s[left]) != Char.ToLower(s[right])){
                break;
            }
            left++;
            right--;
        }
        return left >= right;
    }
}
