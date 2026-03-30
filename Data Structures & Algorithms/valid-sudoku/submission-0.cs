public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var rows = new HashSet<char>[9];
        var cols = new HashSet<char>[9];
        var squares = new HashSet<char>[9];
        for (var i = 0; i < 9; i++){
            rows[i] = new HashSet<char>();
            cols[i] = new HashSet<char>();
            squares[i] = new HashSet<char>();
        }
        for (var i = 0; i < 9; i++){
            var sqRow = i / 3;
            for (var j = 0; j < 9; j++) {
                var ch = board[i][j];
                if (ch == '.'){
                    continue;
                }
                var sqCol = j / 3;
                var row = i;
                var col = j;
                var square = sqRow * 3 + sqCol;
                if (rows[row].Add(ch) && cols[col].Add(ch) && squares[square].Add(ch)){
                    continue;
                }
                return false;
            }
        }

        return true;
    }
}
