using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Solution
    {
        public int MaxSubArray(int[] nums)
        {
            int size = nums.Length;
            if (size == 1)
                return nums[0];
            int sum = int.MinValue;
            int currentSum = 0;
            for (int i = 0; i < size; i++)
            {
                currentSum += nums[i];
                if (sum < currentSum)
                    sum = currentSum;

                if (currentSum < 0)
                    currentSum = 0;
            }
            return sum;
        }
    } 
/*
// use presum method
public class Solution {
    public int MaxSubArray(int[] nums) {
        if (nums == null || nums.Length == 0) return 0;
        int max = nums[0], curSum = nums[0], preMinSum = Math.Min(curSum,0);
        for (int i = 1; i < nums.Length; i++) {
            curSum += nums[i];
            max = Math.Max(max, curSum - preMinSum);
            preMinSum = Math.Min(curSum, preMinSum);
        }
        return max;
    }
}
*/
/*
// dynamic programming
public class Solution {
    public int MaxSubArray(int[] nums) {
        if (nums == null || nums.Length == 0) return 0;
        int n = nums.Length;
        // dp[i] the maximun subarray ending with nums[i]
        int[] dp = new int[n];
        dp[0] = nums[0];
        int max = dp[0];
        for (int i = 1; i < n; i++) {
            dp[i] = nums[i] + (dp[i - 1] > 0 ? dp[i - 1] : 0);
            max = Math.Max(max, dp[i]);
        }
        return max;
    }
}
*/
/*
public class Solution {
    public int MaxSubArray(int[] nums) {
        int res = nums[0], f = nums[0];
        for (int i = 1; i < nums.Length; ++i)
        {
            f = nums[i] + Math.Max(f, 0);
            res = Math.Max(res, f);
        }
        return res;
    }
}
*/

