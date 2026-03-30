public class Solution {
    public bool IsValid(string s) {
        var st = new Stack<char>();
        var mapping = new Dictionary<char, char>(){
            {'}', '{'},
            {']', '['},
            {')', '('}
        };
        var open = new HashSet<char>(new char[]{'{', '[', '('});
        for (var i = 0; i < s.Length; i++){
            var c = s[i];
            if (open.Contains(c)){
                st.Push(c);
            } else if (mapping.TryGetValue(c, out var op)) {
                if (st.Count == 0 || st.Pop() != op) {
                    return false;
                }
            }
        }
        return st.Count == 0;
    }
}
