/*
///Solution1: Dynamic Programming
class Solution {
    public int numSquares(int n) {
        int[] dp = new int[n + 1];
        Arrays.fill(dp, Integer.MAX_VALUE);
        dp[0] = 0;
        
        for (int i = 1; i <= n; i++) {
            // try every possible j s.t. j*j<i
            for (int j = 1; j * j <= i; j++) {
                dp[i] = Math.min(dp[i], dp[i - j * j] + 1);
            }
        }
        
        return dp[n];
    }
} 
*/
//Solution2: BFS looking for shortest path
class Solution {
    public int numSquares(int n) {
        if (n <= 0) return 0;
        
        List<Integer> squares = new ArrayList<>();
        for (int i = 1; i <= n; i++) {
            squares.add(i * i);
        }
        
        int currCount = 0;
        Deque<Integer> deque = new ArrayDeque<>();
        deque.offer(0);
        while (!deque.isEmpty()) {
            currCount++;
            int currLen = deque.size();
            for (int i = 0; i < currLen; i++) {
                int tmp = deque.poll();
                for (int j = 0; j < squares.size(); j++) {
                    if (tmp + squares.get(j) == n) {
                        return currCount;
                    } else if (tmp + squares.get(j) < n) {
                        deque.offer(tmp + squares.get(j));
                    } else {
                        break;
                    }
                }
            }
        }
        
        return 0;
    }
}