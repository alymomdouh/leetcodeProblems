class Solution {
    public int maxProfit(int k, int[] prices) {
        if (k <= 0 || prices == null || prices.length == 0) return 0;
        
        if (k >= prices.length / 2) return quickPath(prices);
        
        int[][] mem = new int[k + 1][prices.length];
        
        for (int i = 1; i <= k; i++) {
            int localMax = -prices[0]; // initial value of localMax = 0 - prices[0] = -prices[0]
            for (int j = 1; j < prices.length; j++) {
                mem[i][j] = Math.max(mem[i][j - 1], prices[j] + localMax);
                
                // will be used in next iteration
                // get max(profit[i-1][prev] - prices[prev]) for each step consecutively
                localMax = Math.max(localMax, mem[i - 1][j] - prices[j]);
            }
        }
        
        return mem[k][prices.length - 1];
    }
    
    private int quickPath(int[] prices) {
        int ret = 0;
        for (int i = 1; i < prices.length; i++) {
            ret += Math.max(0, prices[i] - prices[i - 1]);
        }
        
        return ret;
    }
}