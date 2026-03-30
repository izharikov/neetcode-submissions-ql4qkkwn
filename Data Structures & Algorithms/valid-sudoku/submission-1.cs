public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var rows = new bool[9, 9];
        var cols = new bool[9, 9];
        var squares = new bool[9, 9];
        for (var i = 0; i < 9; i++){
            var sqRow = i / 3;
            for (var j = 0; j < 9; j++) {
                var ch = board[i][j];
                if (ch == '.'){
                    continue;
                }
                var c = ch - '1';
                var sqCol = j / 3;
                var row = i;
                var col = j;
                var square = sqRow * 3 + sqCol;
                if (rows[row, c] || cols[col, c] || squares[square, c]){
                    return false;
                }
                rows[row, c] = true;
                cols[col, c] = true;
                squares[square, c] = true;
            }
        }

        return true;
    }
}
