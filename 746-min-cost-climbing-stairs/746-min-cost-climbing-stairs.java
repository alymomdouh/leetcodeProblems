class Solution {
    public int minCostClimbingStairs(int[] cost) {
        int length = cost.length;
    	int f[] = new int[length+1];
    	// التهيئة
    	f[0]=cost[0];
    	f[1] = cost[1];
    	int value=0;
    	for (int i = 2; i < f.length; i++) {
    		if(i<length){
    		// منع في الخارج
    			value = cost[i];
    		}else{
    			value=0;
    		}
    		f[i] =Math.min(f[i-1] ,f[i-2])+value;
		}
       return f[length]; 
    }
}
