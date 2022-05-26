class Solution {
    public int countSubstrings(String s) {
        int l=s.length();
        int [][]dp=new int [l+1][l+1];
        for(int i=1;i<=l;i++)
        {
            for(int j=i;j<=l;j++)
                dp[i][j]=0;
        }
        int res=0;
        for(int i=1;i<=l;i++)
        {
            for(int j=1;j<=i;j++)
            {
                if(s.charAt(i-1)==s.charAt(j-1)&&(i-j<=2||dp[i-1][j+1]==1))
                    dp[i][j]=1;
                if(dp[i][j]==1)
                    res++;
            }
        }
        return res;
    }
}