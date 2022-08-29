class Solution:
    def numIslands(self, grid):
        """
        :type grid: List[List[str]]
        :rtype: int
        """
        self.row_num = len(grid)
        if self.row_num == 0:
            return 0
        self.column_num = len(grid[0])
        self.visited = [[False for _ in range(self.column_num)] for _ in range(self.row_num)]
        islands = []
        for r in range(self.row_num):
            for c in range(self.column_num):
                if not self.visited[r][c] and grid[r][c] == '1':
                    island = []
                    self.visit(grid,r,c,island)
                    islands.append(island)
        return len(islands)
 
    def visit(self,grid,row,column,island):
        if not self.visited[row][column] and  grid[row][column] == '1':
            self.visited[row][column] = True
            island.append((row,column))
            if row - 1 >= 0:
                self.visit(grid,row-1,column,island)
            if row + 1 < self.row_num:
                self.visit(grid,row+1,column,island)
            if column - 1 >= 0:
                self.visit(grid,row,column-1,island)
            if column + 1 < self.column_num:
                self.visit(grid,row,column+1,island)