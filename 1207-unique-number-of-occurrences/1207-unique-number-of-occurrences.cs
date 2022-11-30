//Approach 1: Counting Sort

public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        int K = 1000; 
         int[] freq = new int[2 * K + 1]; 
        // Store the frequency of elements in the unordered map.
        foreach  (int num in arr) {
            freq[num + K]++;
        } 
        // Sort the frequency count.
        Array.Sort(freq); 
        // If the adjacent freq count is equal, then the freq count isn't unique.
        for (int i = 0; i < 2 * K; i++) {
            if (freq[i] != 0 && freq[i] == freq[i + 1]) {
                return false;
            }
        } 
        // If all the elements are traversed, it implies frequency counts are unique.
        return true;
        
        // var occ = arr.GroupBy(x => x, (int key, IEnumerable<int> all) => all.Count());
        // var set = new HashSet<int>();
        // foreach (var o in occ) {
        //     if (!set.Add(o)) {
        //         return false;
        //     }
        // }
        // return true;
    }
}

/*
public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        var occ = arr.GroupBy(x => x, (int key, IEnumerable<int> all) => all.Count());
        var set = new HashSet<int>();
        foreach (var o in occ) {
            if (!set.Add(o)) {
                return false;
            }
        }
        return true;
    }
}
*/