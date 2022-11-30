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