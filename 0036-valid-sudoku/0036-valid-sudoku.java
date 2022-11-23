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