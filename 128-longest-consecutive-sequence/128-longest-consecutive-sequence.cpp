
class Solution {
public:
    int longestConsecutive(vector<int>& nums) {
      int n = nums.size();
      if (n <= 1){
        return n;
      }
      int ans = 1, l = 1;
      sort(nums.begin(), nums.end());
      for (int i = 0; i < n - 1; i++){
        if (nums[i] == nums[i + 1] - 1){
          l++;
        }
        else if (nums[i] == nums[i + 1]){
          continue;
        }
        else {
          l = 1;
        }
        ans = max(ans, l);
      }
      return ans;
    }
};