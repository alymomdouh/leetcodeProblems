class Solution {
    public int threeSumClosest(int[] nums, int target) {
        int low = 0, high = 0, res = target >= 0 ? Integer.MAX_VALUE: Integer.MIN_VALUE, sum = 0;
        Arrays.sort(nums);
        for(int i = 0; i < nums.length - 2; i ++){
            low = i + 1; high = nums.length - 1;
            while(low < high){
                sum = nums[i] + nums[low] + nums[high];
                if(sum == target) return target;
                else{
                    res = Math.abs(sum - target) < Math.abs(res - target) ? sum: res;
                    if(sum < target) low++;
                    else high--;
                }
            }
        }
        return res;
    }
}