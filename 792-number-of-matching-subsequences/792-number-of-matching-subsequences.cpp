class Solution {
public:
    int numMatchingSubseq(string S, vector<string>& words) {
        vector<pair<int, int>> wait[128];
        int len = words.size();
        for(int i=0; i<len; i++)
            wait[words[i][0]].emplace_back(i, 1);
        for(char c:S){
            auto tmp = wait[c];
            wait[c].clear();
            for(auto it:tmp)
                wait[words[it.first][it.second++]].push_back(it);
        }
        return wait[0].size();
    }
};