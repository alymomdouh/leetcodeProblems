class Solution {
public:
    bool searchMatrix(vector<vector<int>>& matrix, int target) {
        if(matrix.size()==0)    return false;
        if(matrix[0].size()==0)     return false;
        int rows=matrix.size(), cols=matrix[0].size();
        int row=0, col=cols-1;
        while(row<rows && col>=0){
            if(target == matrix[row][col])      return true;
            else if(target < matrix[row][col])      col--;
            else    row++;
        }
        return false;
    }
};