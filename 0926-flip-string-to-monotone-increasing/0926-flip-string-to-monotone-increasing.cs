public class Solution {
    public int MinFlipsMonoIncr(string S) {
        int lz = 0, ro = S.Count(c => c == '1'), n = S.Length, ret = n - ro;
        foreach (char c in S) {
            if (c == '0') {
                ++lz;
            } else {
                --ro;
            }
            int flips = n - lz - ro;
            if (flips < ret) {
                ret = flips;
            }
        }
        return ret;
    }
}