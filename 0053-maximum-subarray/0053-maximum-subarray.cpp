class Solution {
public:
    int maxSubArray(vector<int>& nums) {
        if(nums.size() == 0){
            return -1;
        }
        
        int sum = nums[0];
        int max_temp = nums[0];
        
        for(int i=1; i<nums.size(); i++){
            if(max_temp+nums[i] < nums[i]){
                max_temp = nums[i];
            }
            else{
                max_temp += nums[i];
            }
            sum = max(sum, max_temp);
        }
        
        return sum;
    }
};
