public enum Operation {
    NONE, PLUS, MINUS, MULT, DIV,
}

public class Solution {

    private static Operation GetOperation(string token) {
        if (token.Length == 1) {
            var ch = token[0];
            if (ch == '+') {
                return Operation.PLUS;
            } else if (ch == '-') {
                return Operation.MINUS;
            } else if (ch == '*') {
                return Operation.MULT;
            } else if (ch == '/') {
                return Operation.DIV;
            }
        }
        return Operation.NONE;
    }
    
    public int EvalRPN(string[] tokens) {
        var st = new Stack<int>(tokens.Length / 3);
        for (var i = 0; i < tokens.Length; i++) {
            var token = tokens[i];
            var operation = GetOperation(token);
            if (operation == Operation.NONE) {
                st.Push(int.Parse(token));
            } else {
                var right = st.Pop();
                var left = st.Pop();
                if (operation == Operation.PLUS) {
                    st.Push(left + right);
                } else if (operation == Operation.MINUS) {
                    st.Push(left - right);
                } else if (operation == Operation.MULT) {
                    st.Push(left * right);
                } else if (operation == Operation.DIV) {
                    st.Push(left / right);
                }
            }
        }
        return st.Pop();
    }
}
