// class Solution {
//     public int minDistance(String W1, String W2) {
//         int m = W1.length(), n = W2.length();
//         if (m < n) {
//             String tempStr = W1;
//             W1 = W2;
//             W2 = tempStr;
//             int tempInt = n;
//             n = m;
//             m = tempInt;
//         }
//         char[] WA1 = W1.toCharArray(), WA2 = W2.toCharArray();
//         int[] dpLast = new int[n+1], dpCurr = new int[n+1];
//         for (char c1 : WA1) {
//             for (int j = 0; j < n; j++) 
//                 dpCurr[j+1] = c1 == WA2[j]
//                     ? dpLast[j] + 1
//                     : Math.max(dpCurr[j], dpLast[j+1]);
//             int[] tempArr = dpLast;
//             dpLast = dpCurr;
//             dpCurr = tempArr;
//         }
//         return m + n - 2 * dpLast[n];
//     }
// }

//My Java Solution by using LCS concept
class Solution {
    public int minDistance(String word1, String word2) {
        if (word1.equals(word2))
            return 0;
        int length1 = word1.length();
        int length2 = word2.length();
        int [][] dp = new int [length1 + 1][length2 + 1];
        for (int i=1; i<=length1; i++) {
            for (int j=1; j<=length2; j++) {
                if (word1.charAt(i - 1) == word2.charAt(j -1))
                    dp[i][j] = dp[i - 1][j - 1] + 1;
                else
                    dp[i][j] = Math.max(dp[i-1][j], dp[i][j - 1]);
            }
        }
        int longestCommon = dp[length1][length2];
        return length1 - longestCommon + length2 - longestCommon;
    }
}
