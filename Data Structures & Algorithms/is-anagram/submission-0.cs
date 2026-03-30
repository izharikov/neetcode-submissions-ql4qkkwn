public class Solution {

    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length){
            return false;
        }
        var res = new Dictionary<char, int>();
        for (var i = 0; i < s.Length; i++){
            var c = s[i];
            if (res.TryGetValue(c, out var v)){
                res[c] = v + 1;
            } else {
                res[c] = v + 1;
            }
        }
        
        for (var i = 0; i < t.Length; i++){
            var c = t[i];
            if (res.TryGetValue(c, out var v)){
                res[c] = v - 1;
            } else {
                return false;
            }
            if (res[c] < 0){
                return false;
            }
        }

        return true;
    }
}
