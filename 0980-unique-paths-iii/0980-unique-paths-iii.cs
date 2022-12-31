/*
using System.Collections.Generic;
 public class Solution {
    private static int UniquePathsRecurse(int[][] grid, int m, int n, int i, int j, int count, HashSet<(int Row, int Col)> visited) {
        if (i < 0 || i >= m || j < 0 || j >= n || grid[i][j] == -1) {
            return 0;
        }
        if (grid[i][j] == 2) {
            if (visited.Count == count) {
                return 1;
            }
            return 0;
        }
        var key = (Row: i, Col: j);
        if (visited.Contains(key)) {
            return 0;
        }
        visited.Add(key);
        int ret = UniquePathsRecurse(grid, m, n, i - 1, j, count, visited) + UniquePathsRecurse(grid, m, n, i + 1, j, count, visited) + UniquePathsRecurse(grid, m, n, i, j - 1, count, visited) + UniquePathsRecurse(grid, m, n, i, j + 1, count, visited);
        visited.Remove(key);
        return ret;
    }
    public int UniquePathsIII(int[][] grid) {
        int m = grid.Length, n = grid[0].Length, si = -1, sj = -1, count = 1;
        for (int i = 0; i < m; ++i) {
            for (int j = 0; j < n; ++j) {
                if (grid[i][j] == 1) {
                    si = i;
                    sj = j;
                } else if (grid[i][j] == 0) {
                    ++count;
                }
            }
        }
        return UniquePathsRecurse(grid, m, n, si, sj, count, new HashSet<(int Row, int Col)>());
    }
} 
*/

public class Solution
  {
    public int UniquePathsIII(int[][] grid)
   {
      var start = (0, 0);
      var end = (0, 0);
      var obs = new HashSet<(int, int)>();


      for (var i = 0; i < grid.Length; i++)
      {
        for (var j = 0; j < grid[0].Length; j++)
        {
          if (grid[i][j] == 1) start = (i, j);
          if (grid[i][j] == 2) end = (i, j);
          if (grid[i][j] == -1) obs.Add((i, j));
        }
      }

      var visited = new HashSet<(int, int)>() { start };

      return GetNumber(start, end, obs, visited, grid, grid.Length, grid[0].Length);
    }

    private int GetNumber((int, int) start, (int, int) end, HashSet<(int, int)> obs, HashSet<(int, int)> visited, int[][] grid, int rows, int cols)
        {
      if (start == end)
      {
        if (visited.Count + obs.Count == rows * cols)
          return 1;
        return 0;
      }

      var ans = 0;

      var dirs = new List<(int x, int y)>()
        {
            (start.Item1 + 0, start.Item2 + 1),
            (start.Item1 + 0, start.Item2 - 1),
            (start.Item1 + 1, start.Item2 + 0),
            (start.Item1 - 1, start.Item2 + 0),
          };

      foreach (var (x, y) in dirs)
      {
        if (x < 0 || y < 0 || x == rows || y == cols)
          continue;

        if (visited.Contains((x, y)) || obs.Contains((x, y)))
          continue;

        visited.Add((x, y));
        ans += GetNumber((x, y), end, obs, visited, grid, rows, cols);
        visited.Remove((x, y));
      }

      return ans;
    }
  }
