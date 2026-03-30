public class Solution {
    const char Separator = '#';
    public string Encode(IList<string> strs) {
        if (strs.Count == 0){
            return null;
        }
        var res = new StringBuilder();
        for (var i = 0; i < strs.Count; i++){
            var s = strs[i];
            res.Append(s.Length).Append(Separator).Append(s);
        }
        return res.ToString();
    }

    public List<string> Decode(string s) {
        if (s == null){
            return new List<string>();
        }
        var res = new List<string>();
        for (var i = 0; i < s.Length; ){
            var sepEnd = s.IndexOf(Separator, i + 1, s.Length - i - 1);
            var lenStr = s.Substring(i, sepEnd - i);
            var len = int.Parse(lenStr);
            res.Add(s.Substring(sepEnd + 1, len));
            i = sepEnd + len + 1;
        }

        return res;
    }
}
