/*
class Solution {
  public boolean isValidSudoku(char[][] board) {
    Set<String> seen = new HashSet<>();

    for (int i = 0; i < 9; ++i)
      for (int j = 0; j < 9; ++j) {
        if (board[i][j] != '.') {
            char c = board[i][j];
        if (!seen.add(c + "found in row" + i) ||
            !seen.add(c + "found in col" + j) ||
            !seen.add(c + "found in box" + i / 3 + j / 3))
          return false;
        }  
      }

    return true;
  }
}
*/
public class Solution {
    public boolean isValidSudoku(char[][] board) {
        for(int i = 0; i < 9; i++){
            Set<Character> rows = new HashSet<Character>();
            Set<Character> columns = new HashSet<Character>();
            Set<Character> cube = new HashSet<Character>();
            for(int j = 0; j < 9; j++){
                // Check row
                if(board[i][j] != '.' && !rows.add(board[i][j])){
                    return false;
                }
                
                // Check column
                if(board[j][i] != '.' && !columns.add(board[j][i])){
                    return false;
                }
                
                // Check cube
                int rowIndex = 3 * (i / 3);     // row index of current cube
                int colIndex = 3 * (i % 3);     // col index of current cube
                if(board[rowIndex + j / 3][colIndex + j % 3] != '.' &&
                   !cube.add(board[rowIndex + j / 3][colIndex + j % 3])){
                       return false;
                }
            }
        }
        return true;
    }
}