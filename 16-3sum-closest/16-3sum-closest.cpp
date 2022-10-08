class Solution {
public:
    int threeSumClosest(vector<int>& nums, int target) {
        int res = nums[0]+nums[1]+nums[2];
        int min = abs(nums[0]+nums[1]+nums[2]-target);
        if(min==0)
            return target;
            
        sort(nums.begin(), nums.end());
        
        for(int i=0; i<nums.size()-2; i++){
            int front = i+1;
            int back = nums.size()-1;
            
            while(front<back){
                int sum = nums[i]+nums[front]+nums[back];
                if(sum==target)
                    return target;
                
                if(abs(sum-target)<min){
                    min = abs(sum-target);
                    res = sum;
                    int minfront = front;
                    int minback = back;
                    // while(front<back && nums[front]==nums[minfront])
                    //     front++;
                    // while(front<back && nums[back]==nums[minback])
                    //     back--;
                }  
                else{
                    if(sum<target){
                        front++;
                    }
                    else if(sum>target){
                        back--;
                    }                                 
                }

            }
            
            while(i+1<nums.size() && nums[i+1]==nums[i])
                i++;
            
        }
        
        return res;
    }
};
