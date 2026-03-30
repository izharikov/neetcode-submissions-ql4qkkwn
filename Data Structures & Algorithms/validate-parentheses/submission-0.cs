public class Solution {
    public bool IsValid(string s) {
        var st = new Stack<char>();
        char[,] parentheses = { {'{', '[', '('}, {'}', ']', ')'} };
        const int COUNT = 3;
                for (var i = 0; i < s.Length; i++){
            var c = s[i];
            for (var j = 0; j < COUNT; j++) {
                if (c == parentheses[0, j]) {
                    st.Push(c);
                    break;
                } else if (c == parentheses[1, j]) {
                    // it's closing
                    if (st.Pop() != parentheses[0, j]) {
                        return false;
                    }
                }
            }
        }
        return st.Count == 0;
    }
}
