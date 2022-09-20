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

// class Solution {
//     public int findLength(int[] A, int[] B) {
//         int m = A.length, n = B.length;
//         int[][] dp = new int[m + 1][n + 1];
//         int ans = 0;
//         for (int i = 0; i < m; i++) {
//             for (int j = 0; j < n; j++) {
//                 if (A[i] == B[j]) {
//                     dp[i + 1][j + 1] = dp[i][j] + 1;
//                     ans = Math.max(ans, dp[i + 1][j + 1]);
//                 }
//             }
//         }
//         return ans;
//     }
// }

//Binary Search with Rolling Hash

import java.math.BigInteger;

class Solution {
    private int p = 113;
    private int M = 1000000007;
    private int pInv = BigInteger.valueOf(p).modInverse(BigInteger.valueOf(M)).intValue();

    public int findLength(int[] A, int[] B) {
        int lo = 0, hi = Math.min(A.length, B.length);
        while (lo < hi) {
            int mi = lo + (hi - lo + 1) / 2;
            if (checkLength(mi, A, B)) lo = mi;
            else hi = mi - 1;
        }
        return lo;
    }

    private boolean checkLength(int x, int[] A, int[] B) {
        Map<Integer, List<Integer>> map = new HashMap<>();
        int k = 0;
        for (int h : getHashes2(A, x)) {
            map.computeIfAbsent(h, z -> new ArrayList<>()).add(k++);
        }
        int j = 0;
        for (int h : getHashes2(B, x)) {
            for (int i : map.getOrDefault(h, new ArrayList<>())) {
                if (Arrays.equals(Arrays.copyOfRange(A, i, i + x), Arrays.copyOfRange(B, j, j + x))) return true;
            }
            j++;
        }
        return false;
    }

    private int[] getHashes(int[] a, int L) {
        int[] res = new int[a.length - L + 1];
        long h = 0, power = 1;
        for (int i = 0; i < L - 1; i++) {
            h = (h + a[i] * power) % M;
            power = (power * p) % M;
        }
        for (int i = L - 1; i < a.length; i++) {
            h = (h + a[i] * power) % M;
            res[i - L + 1] = (int) h;
            h = (h - a[i - L + 1]) * pInv % M;
        }
        return res;
    }

    private int[] getHashes2(int[] a, int L) {
        int[] res = new int[a.length - L + 1];
        long h = 0, power = 1;
        for (int i = 0; i < L - 1; i++) {
            h = (h * p % M + a[i]) % M;
            power = (power * p) % M;
        }
        for (int i = L - 1; i < a.length; i++) {
            h = (h * p % M + a[i]) % M;
            res[i - L + 1] = (int) h;
            h = (h - a[i - L + 1] * power) % M;
            if (h < 0) h += M;
        }
        return res;
    }
}