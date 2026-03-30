public class Solution {
    private string GenerateKey(string s){
        var arr = new int[28];
        for (var i = 0; i < s.Length; i++){
            arr[s[i] - 'a'] += 1;
        }
        return string.Join(string.Empty, arr);
    }
    public List<List<string>> GroupAnagrams(string[] strs) {
        var res = strs.GroupBy(x => GenerateKey(x));
        return res.Select(x => x.ToList()).ToList();
    }
}
