class Solution { 
    public int missingNumber1(int[] nums) {
        int n = nums.length + 1;
        int sum = n*(n-1)/2;

        for (int num:nums) {
            sum -= num;
        }

        return sum;
    }
    public int missingNumber(int[] nums) {
        int missing = nums.length;
        for (int i = 0; i < nums.length; i++) {
            missing ^= i^nums[i];
        }

        return missing;
    }

}