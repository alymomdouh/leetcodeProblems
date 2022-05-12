class Solution {
private:
	void  permute(vector<int>& nums, int start, set<vector<int>>& result) {
 
		if (start == nums.size())
			result.insert(nums);
 
		for (int i = start; i < nums.size(); i++) {
			swap(nums[i], nums[start]);
			permute(nums, start + 1, result);
			swap(nums[i], nums[start]);
		}
	}
 
public:
	vector<vector<int>> permuteUnique(vector<int>& nums) {
		set<vector<int>> s;
		permute(nums, 0, s);
 
		vector<vector<int>> vec(s.begin(), s.end());
 
		return vec;
	}
};