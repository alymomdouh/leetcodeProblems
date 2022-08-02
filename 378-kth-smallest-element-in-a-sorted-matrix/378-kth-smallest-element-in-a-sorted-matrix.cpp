class Solution {
public:
    int kthSmallest(vector<vector<int>>& matrix, int k) {
        priority_queue<int> q;
        int m=matrix.size();
        int n=matrix[0].size();
        for(int i=0;i<m;i++){
            for(int j=0;j<n;j++){
                q.emplace(matrix[i][j]);
                if(q.size()>k){
                    q.pop();
                }
            }
        }
        return q.top();
    }
};
