class Solution {
private:
    int lenS,lenT;
    queue<int> Q;
    void ini(string &stamp,string &target){
        lenS=stamp.size();
        lenT=target.size();
    }
public:
    vector<int> movesToStamp(string stamp, string target) {
        vector<int> n;
        stack<int> store;
        ini(stamp,target);
        if(stamp[0]!=target[0])
            return n;
        auto stampLast=stamp.end()-1;
        auto targetLast=target.end()-1;
        if(*stampLast!=*targetLast)
            return n;
        vector<bool> match(lenT,false);
        int sum=0;
        queue<int> Q;
        for(int i=0;i<=lenT-lenS;i++)
            if(isSame(i,stamp,target)){
                Q.push(i);
            }
        int now;
        while(!Q.empty()){
            now=Q.front();
            Q.pop();
            if(match[now])
                continue;
            if(isSame(now,stamp,target)){
                match[now]=true;
                store.push(now);
                int star=now-lenS+1<0 ? 0:now-lenS+1;
                int lim=(now+lenS-1 > lenT-lenS) ? lenT-lenS:now+lenS-1;
                for(int i=star;i<= lim ; i++){
                    if(!match[i])
                        Q.push(i);
                }
                sum+=change(now,target);
            }
        }
        if(sum==lenT){
            vector<int> ans;
            while(!store.empty()){
                ans.push_back(store.top());
                store.pop();
            }
            return ans;
        }
        else
            return n;
    }
    bool isSame(int index,string &stamp,string &target){
        for(int i=index,j=0;i<index+lenS;i++,j++){
            if(target[i]=='?')
                continue;
            if(stamp[j]!=target[i])
                return false;
        }
        return true;
    }
    inline int change(int index,string &target){
        int num=0;
        for(int i=index;i<index+lenS;i++)
            if(target[i]!='?'){
                target[i]='?';
                num++;
            }
        return num;
    }
};
