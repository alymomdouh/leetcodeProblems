//Using Prefix Sum
/*
class Solution {
    public int minOperations(int[] nums, int x) {
        int target = -x;
        for(int i : nums) target+=i;
        if(target == 0) return nums.length;
        Map<Integer, Integer> map = new HashMap<>();
        map.put(0,-1);
        int res = -1, sum = 0;
        
        for(int i = 0; i < nums.length; i++) {
            sum+=nums[i];
            if(map.containsKey(sum-target)) {
                res = Math.max(res, i-map.get(sum-target));
            }
            map.put(sum, i);
        }
        
        return res==-1 ? -1 : nums.length - res;
    }
}
***/
//Using Siding Window
 
class Solution {
    public int minOperations(int[] nums, int x) {
        int target = -x;
        for(int i : nums) target+=i;
        if(target == 0) return nums.length;
        if(target < 0) return -1;
        int res = -1, sum = 0, left = 0;
        
        for(int i = 0; i < nums.length; i++) {
            sum+=nums[i];
            while(sum > target){
                sum-=nums[left++];
            }
            if(sum == target){
                res = Math.max(res, i-left+1);
            }
        }
        
        return res==-1 ? -1 : nums.length - res;
    }
}