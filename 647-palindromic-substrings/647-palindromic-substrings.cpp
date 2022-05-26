 class Solution {
public:
    int countSubstrings(string s) {
        int ans = 0, n = s.length();
        for (int i = 0; i < n; i++) {
            for (int j = 0; i + j < n && i - j >= 0 && s[i-j] == s[i+j]; j++) ans++;
            for (int j = 0; i + j < n && i - j - 1 >=0 && s[i-j-1] == s[i+j]; j++) ans++;
        }
        return ans;
    }
};