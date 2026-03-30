public class Solution {

    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length){
            return false;
        }

        var res = new int[26];
        for (var i = 0; i < s.Length; i++){
            var c = s[i] - 'a';
            res[c] = res[c] + 1;
        }
        
        for (var i = 0; i < t.Length; i++){
            var c = t[i] - 'a';
            res[c] = res[c] - 1;
            if (res[c] < 0){
                return false;
            }
        }

        return true;
    }
}
