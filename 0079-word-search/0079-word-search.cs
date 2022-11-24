public class Solution {
    public bool Exist(char[][] board, String word) {
        if (board == null || board.Length == 0 || board[0].Length == 0 || word == null ) {//|| word.equals("")
            return false;
        }
        for (int i = 0; i < board.Length; i ++) {
            for (int j = 0; j < board[0].Length; j ++) {
                if (search(board, word, i, j, 0) == true) {
                    return true;
                }
            }
        }
        return false;
    }
    private bool search(char[][] board, String word, int i, int j, int matched) {
        if (matched == word.Length) {
            return true;
        }
        if (i < 0 || j < 0 || i >= board.Length || j >= board[0].Length || board[i][j] != word[matched]) {
            return false;
        }
        board[i][j] = '#';
        bool result = search(board, word, i - 1, j, matched + 1) || search(board, word, i, j - 1, matched + 1) ||                           search(board, word, i + 1, j, matched + 1) ||  search(board, word, i, j + 1, matched + 1);
        board[i][j] = word[matched];
        return result;
    }
}