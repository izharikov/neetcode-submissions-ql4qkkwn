public class Solution {
    public bool IsValid(string s) {
        var st = new Stack<char>();
        
        for (var i = 0; i < s.Length; i++){
            var c = s[i];
            switch (c) {
                case '{':
                case '[':
                case '(':
                    st.Push(c);
                    continue;
                case '}':
                    if (st.Count == 0 || st.Pop() != '{') {
                        return false;
                    }
                    continue;
                case ']':
                    if (st.Count == 0 || st.Pop() != '[') {
                        return false;
                    }
                    continue;
                case ')':
                    if (st.Count == 0 || st.Pop() != '(') {
                        return false;
                    }
                    continue;  
            }
        }
        return st.Count == 0;
    }
}
