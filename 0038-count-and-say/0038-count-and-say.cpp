class Solution {
public:
    string countAndSay(int n) {
        string ans;
        ans="1";
        for(int i=1;i<n;i++){
            solve(ans);
        }
        return ans;
    }
    void solve(string &ans){
        string tmp="";
        int count=1;
        for(int i=0;i<ans.size();i++){
            if(i+1<ans.size()&&ans[i]==ans[i+1]){
                count++;
            }else{
                char ch=count+'0';
                tmp=tmp+ch+ans[i];
                count=1;
            }
        }
        ans=tmp;
    }
};
