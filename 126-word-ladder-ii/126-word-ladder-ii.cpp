class Solution {
private:
    // سجل بنية حالة البحث الواسعة
    struct LadderState
    {
        vector<string> frontState;  // سجل الحالة الحالية من أي تحويل حالة
        int level;                  // سجل عدد الطبقات في الحالة الحالية
    };
private:
    // تحديد ما إذا كانت كلمتين تختلفان بحرف واحد فقط
    bool isNear(string lhv, string rhv)
    {
        if(lhv.size() != rhv.size()) return false;

        int cnt = 0;
        for(int i = 0; i < lhv.size() && cnt < 2; ++i)
        {
            if(lhv[i] != rhv[i])
            {
                ++cnt;
            }
        }

        return (cnt == 1);
    }    
    // إرجاع جميع أقصر المسارات إلى endWord
    set<vector<string>> recoverPaths(string beginWord, string endWord, map<string, LadderState>& wordStates)
    {
        if(beginWord == endWord) return {{beginWord}};
        set<vector<string>> paths;
        for(size_t i = 0; i < wordStates[endWord].frontState.size(); ++i)
        {
            set<vector<string>> curPaths = recoverPaths(beginWord, wordStates[endWord].frontState[i], wordStates);
            for(auto path : curPaths)
            {
                path.push_back(endWord);
                paths.insert(path);
            }
        }

        return paths;
    }
public:
    vector<vector<string>> findLadders(string beginWord, string endWord, vector<string>& wordList) {
        multimap<string, string> wordDir; // wordDir [i] = j تعني أن i إلى j تختلف بحرف واحد فقط

        // احسب المسافة وقم بتخزين العقد المجاورة في WordDir
        for(int i = 0; i < wordList.size(); ++i)
        {
            for(int j = i+1; j < wordList.size(); ++j)
            {
                if(isNear(wordList[i], wordList[j]))
                {
                    wordDir.insert({wordList[i], wordList[j]});
                    wordDir.insert({wordList[j], wordList[i]});
                }
            }
        }
        for(int i = 0; i < wordList.size(); ++i)
        {
            if(isNear(wordList[i], beginWord))
            {
                wordDir.insert({wordList[i], beginWord});
                wordDir.insert({beginWord, wordList[i]});
            }
        }

        // تهيئة حالة كل عقدة
        map<string, LadderState> wordStates;
        for(size_t i = 0; i < wordList.size(); ++i)
        {
            wordStates[wordList[i]] = { {}, 0};
        }
        wordStates[beginWord] = { {}, 0 };

        // احسب أقصر طريق
        queue<string> que;
        unordered_set<string> flags;

        que.push(beginWord);
        que.push("#");
        flags.insert(beginWord);
        int stepNum = 0;

        while(!que.empty())
        {
            string curWord = que.front();
            que.pop();

            if(curWord == "#") 
            {
                ++stepNum;
                if(!que.empty()) que.push("#");
                continue;
            }

            if(curWord == endWord)
            {
                continue;
            }

            for(auto iter = wordDir.find(curWord); iter != wordDir.end() && iter->first == curWord; ++iter)
            {
                if(flags.find(iter->second) == flags.end())
                {
                    flags.insert(iter->second);
                    que.push(iter->second);
                    wordStates[iter->second].level = wordStates[curWord].level + 1;
                }

                if(wordStates[iter->second].level == wordStates[curWord].level + 1)
                {
                    wordStates[iter->second].frontState.push_back(curWord);
                }
            }
        }

        // استعادة كل مسار وفقًا لـ wordStates
        set<vector<string>> paths = recoverPaths(beginWord, endWord, wordStates);
        vector<vector<string>> ans(paths.begin(), paths.end());
        return ans;
    }
};