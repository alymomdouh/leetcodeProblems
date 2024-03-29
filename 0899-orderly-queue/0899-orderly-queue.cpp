class Solution {
public:
    string orderlyQueue(string S, int K) {
        if (K > 1) {
            sort(S.begin(), S.end());
            return S;
        }
        string res = S;
        for (int i = 0; i < S.size(); i++) {
            res = min(res, S.substr(i) + S.substr(0, i));
        }
        return res;
    }
};