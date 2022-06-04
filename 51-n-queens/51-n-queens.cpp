class Solution {
public:
    vector<vector<string>> result;
    vector<vector<string>> solveNQueens(int n) {
        vector<int> visit(n, -1);
        
        solve(0, visit);
        
        return result;
    }
    
    void solve(int now, vector<int> &visit){
        int n=visit.size();
        if(now==n){
            vector<string> tmp(n, string(n,'.'));
            for(int i = 0; i < n; i++)
                tmp[i][visit[i]] = 'Q';
            result.push_back(tmp);
            return;
        }
        for(int col=0; col<n; col++){
            if(isvalid(visit, col, now)){
                visit[now] = col;
                solve(now+1, visit);
                visit[now] = -1;
            }
        }
    }
    
    bool isvalid(vector<int> &visit, int col, int now){
        for(int i=0; i<now; i++){
            if(visit[i] == col ||  abs(now-i)==abs(col-visit[i]))
                return false;
        }
        return true;
    }
};