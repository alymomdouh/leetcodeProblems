class Solution {
public:
    int maxSumSubmatrix(vector<vector<int>>& matrix, int k) {
        if(matrix.empty()||matrix[0].empty()){
            return 0;
        }
        int m=matrix.size(),n=matrix[0].size();
        int sum[m][n];
        int res=INT_MIN;
        for(int i=0;i<m;i++){
            for(int j=0;j<n;j++){
                int t=matrix[i][j];
                if(i>0) t+=sum[i-1][j];
                if(j>0) t+=sum[i][j-1];
                if(i>0&&j>0) t-=sum[i-1][j-1];
                sum[i][j]=t;
                for(int r=0;r<=i;r++){
                    for(int c=0;c<=j;c++){
                        int d=sum[i][j];
                        if(r>0) d-=sum[r-1][j];
                        if(c>0) d-=sum[i][c-1];
                        if(r>0&&c>0){
                            d+=sum[r-1][c-1];
                        }
                        if(d<=k){
                            res=max(res,d);
                        }
                        
                    }
                }
            }
        }
        return res;
    }
};
