//Dynamic Bottom up
/*
class Solution {
    public int numRollsToTarget(int d, int f, int target) {
        int MOD = (int)Math.pow(10, 9) + 7;
        long[][] dp = new long[d + 1][target + 1];
        dp[0][0] = 1;
        for (int i = 1; i <= d; i++) {// for dice 
            for (int j = 0; j <= target; j++) { // for target
                for (int k = 1; k <= f; k++) { //for faces
                    if (j >= k) {    // dp[i][0] == 0
                        dp[i][j] = (dp[i][j] + dp[i - 1][j - k]) % MOD;
                    } else {
                        break;
                    }
                }
            }
        }

        return (int)dp[d][target];
    }
}
**/
/* https://wentao-shao.gitbook.io/leetcode/dynamic-programming/backpack-problem/1155.number-of-dice-rolls-with-target-sum#approach-2-dynamic-bottom-up  **/

class Solution {
    public int numRollsToTarget(int d, int f, int target) {
        int[][] dp = new int[d + 1][target + 1];
        dp[0][0] = 1;
        int mod=1_000_000_007;
        for (int i = 1; i <= d; i++) {
            for (int j = 1; j <= f; j++) {
                for (int k = target; k >= j; k--) {
                    if(dp[i-1][k-j]!=0){
                        dp[i][k]+=dp[i-1][k-j];
                        dp[i][k]=dp[i][k]% mod;
                    }
                }
            }
        }
        return dp[d][target];
    }
}