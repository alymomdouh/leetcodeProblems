//Naive Binary Search
// class Solution {
//     public int findLength(int[] A, int[] B) {
//         int lo = 0, hi = Math.min(A.length, B.length);
//         while (lo < hi) {
//             int mi = lo + (hi - lo + 1) / 2;
//             if (checkLength(mi, A, B)) lo = mi;
//             else hi = mi - 1;
//         }
//         return lo;
//     }

//     private boolean checkLength(int x, int[] A, int[] B) {
//         if (x == 0) return true;
//         else if (x > Math.min(A.length, B.length)) return false;
//         else {
//             Set<String> seen = new HashSet<>();
//             for (int i = 0; i + x <= A.length; i++) {
//                 seen.add(Arrays.toString(Arrays.copyOfRange(A, i, i + x)));
//             }
//             for (int i = 0; i + x <= B.length; i++) {
//                 if (seen.contains(Arrays.toString(Arrays.copyOfRange(B, i, i + x)))) {
//                     return true;
//                 }
//             }
//             return false;
//         }
//     }
// }

//DP

class Solution {
    public int findLength(int[] A, int[] B) {
        int m = A.length, n = B.length;
        int[][] dp = new int[m + 1][n + 1];
        int ans = 0;
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                if (A[i] == B[j]) {
                    dp[i + 1][j + 1] = dp[i][j] + 1;
                    ans = Math.max(ans, dp[i + 1][j + 1]);
                }
            }
        }
        return ans;
    }
}