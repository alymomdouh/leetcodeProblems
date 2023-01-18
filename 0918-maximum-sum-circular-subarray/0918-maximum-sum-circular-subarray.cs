public class Solution {
    public int MaxSubarraySumCircular(int[] A) {
        int sum = 0, max = int.MinValue, min = int.MaxValue, currMax = 0, currMin = 0;
        foreach (int num in A) {
            currMax = Math.Max(currMax + num, num);
            max = Math.Max(max, currMax);
            currMin = Math.Min(currMin + num, num);
            min = Math.Min(min, currMin);
            sum += num;
        }
        return min == sum ? max : Math.Max(max, sum - min);
    }
}