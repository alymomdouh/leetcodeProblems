 function maxOperations(nums: number[], k: number): number {
   let counter = 0;
    nums.sort((a, b) => a - b);
    let l = 0, j = nums.length - 1;
 
    while (l < j) {
        if (nums[l] + nums[j] < k) {
            l++;
        } else if (nums[l] + nums[j] > k) {
            j--;
        } else {
            counter++;
            l++;
            j--;
        }
    }
 
    return counter;
};