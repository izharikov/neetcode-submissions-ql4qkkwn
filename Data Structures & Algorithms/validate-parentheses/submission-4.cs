public class Solution {
    public bool IsValid(string s) {
        var st = new Stack<char>();
        var mapping = new Dictionary<char, char>(){
            {'}', '{'},
            {']', '['},
            {')', '('}
        };
        for (var i = 0; i < s.Length; i++){
            var c = s[i];
            if (mapping.TryGetValue(c, out var op)) {
                if (st.Count == 0 || st.Pop() != op) {
                    return false;
                }
            } else {
                st.Push(c);
            }
        }
        return st.Count == 0;
    }
}
