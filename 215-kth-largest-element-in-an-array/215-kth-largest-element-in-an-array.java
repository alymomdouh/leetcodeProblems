// class Solution {
//     public int findKthLargest(int[] nums, int k) {
//         Arrays.sort(nums);
//         return nums[nums.length-k];
//     }
// }
/// other solation 
//Min Heap of size N
// class Solution {

//     public int findKthLargest(int[] nums, int k) {
//         int n = nums.length;

//         if (n == 1) {
//             return nums[0];
//         }

//         PriorityQueue<Integer> minHeap = new PriorityQueue();

//         for(int num: nums){
//             minHeap.offer(num);
//         }

//         int i = 0;
//         int kThLargest = minHeap.poll();

//         while (i++ < (n - k)) {
//             kThLargest = minHeap.poll();
//         }

//         return kThLargest;
//     }
// }

//Max Heap of size N
class Solution {
    public int findKthLargest(int[] nums, int k) {

        int len = nums.length;

        if(len == 1){
            return nums[0];
        }

// Since we are using Max-Heap, we need to sortaccordingly
    Comparator<Integer> comp = (a,b) -> b.compareTo(a);
    PriorityQueue<Integer> maxHeap = new PriorityQueue<>(comp);

        // Add all the elements
        for(int num: nums){
            maxHeap.offer(num);
        }

        // we need to poll for k-1 times and
        // return the next polled element
        int i = 1;

        while(i++ < k){
            maxHeap.poll();
        }

        return  maxHeap.poll();

    }
}