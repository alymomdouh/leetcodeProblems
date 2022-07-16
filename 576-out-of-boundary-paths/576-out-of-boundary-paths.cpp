class Solution {
public:
    int mod = 1000000007;
    int findPaths(int m, int n, int N, int i, int j) {
        vector<vector<vector<int>>>res(N+1, vector<vector<int>>(m, vector<int>(n, -1)));
        return DFS(res,m, n, N, i, j);
    }
    int DFS(vector<vector<vector<int>>> &res, int m, int n, int N, int i, int j) {
        if (i<0 || j<0 || i >= m || j >= n) {
            return 1;
        }
        if (N <= 0)return 0;
        if (res[N][i][j] != -1)return res[N][i][j]%mod;
        res[N][i][j] = (((DFS(res, m, n, N - 1, i + 1, j)%mod + DFS(res, m, n, N - 1, i, j + 1))%mod + DFS(res, m, n, N - 1, i - 1, j))%mod + DFS(res, m, n, N - 1, i, j - 1))%mod;
        return res[N][i][j]%mod;
    }
};