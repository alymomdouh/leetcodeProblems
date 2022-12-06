public class Solution {
    public int[] TwoSum(int[] nums, int target) {
       if (nums == null || nums.Length < 2)
            {
                return null;
            }
            var map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (map.ContainsKey(target - nums[i]))
                {
                    return new int[] { i, map[target - nums[i]] };
                }
                if (!map.ContainsKey(nums[i]))
                {
                    map.Add(nums[i], i);
                }
            }
            return null; 
    }
}