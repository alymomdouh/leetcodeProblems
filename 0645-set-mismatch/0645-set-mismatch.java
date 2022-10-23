class Solution {
   //O(N)time O(N)space
// public int[] findErrorNums(int[] nums) {
//     int[] t = new int[nums.length];
//     int res[] = new int[2];
//     int sum = 0;
//     for(int i = 0; i < nums.length; i++){
//         if(t[nums[i] - 1] == 1){
//             res[0] = nums[i];
//         }
//         t[nums[i] - 1] = 1;
//         sum += i + 1 - nums[i];
//     }
//     res[1] = res[0] + sum;
//     return res;
// }
    //O(N)time O(1)space
public int[] findErrorNums(int[] nums) {
    int dup = -1;
    int sum = 0;
    for (int i = 0; i < nums.length; i++) {
        if (nums[Math.abs(nums[i]) - 1] < 0)
            dup = Math.abs(nums[i]);
        else
            nums[Math.abs(nums[i]) - 1] *= -1;

        sum += i + 1 - Math.abs(nums[i]);
    }
    return new int[]{dup, dup + sum};
}
}