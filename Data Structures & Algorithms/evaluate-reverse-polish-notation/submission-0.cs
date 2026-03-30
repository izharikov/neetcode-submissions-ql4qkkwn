public class Solution {
    public int EvalRPN(string[] tokens) {
        var st = new Stack<int>();
        for (var i = 0; i < tokens.Length; i++) {
            var token = tokens[i];
            switch (token) {
                case "*":
                    var right = st.Pop();
                    var left = st.Pop();
                    st.Push(left * right);
                    continue;
                case "-":
                    var r = st.Pop();
                    var l = st.Pop();
                    st.Push(l - r);
                    continue;
                case "+":
                    var right2 = st.Pop();
                    var left2 = st.Pop();
                    st.Push(left2 + right2);
                    continue;
                case "/":
                    var right3 = st.Pop();
                    var left3 = st.Pop();
                    st.Push(left3 / right3);
                    continue;
                default:
                    st.Push(int.Parse(token));
                    continue;
            }
        }
        return st.Pop();
    }
}
