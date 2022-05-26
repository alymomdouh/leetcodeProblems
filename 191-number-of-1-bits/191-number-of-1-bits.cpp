 class Solution {
public:
    int hammingWeight(uint32_t v) {
        auto count = 0;
        while (v != 0) {
            v &= (v - 1);
            ++count;
        }
        return count;
    }
};