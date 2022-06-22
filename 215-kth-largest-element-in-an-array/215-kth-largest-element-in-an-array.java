// class Solution {
//     public int findKthLargest(int[] nums, int k) {
//         Arrays.sort(nums);
//         return nums[nums.length-k];
//     }
// }
/// other solation 
//Min Heap of size N
class Solution {

    public int findKthLargest(int[] nums, int k) {
        int n = nums.length;

        if (n == 1) {
            return nums[0];
        }

        PriorityQueue<Integer> minHeap = new PriorityQueue();

        for(int num: nums){
            minHeap.offer(num);
        }

        int i = 0;
        int kThLargest = minHeap.poll();

        while (i++ < (n - k)) {
            kThLargest = minHeap.poll();
        }

        return kThLargest;
    }
}