bool comp(vector<int>&a,vector<int>&b)
{
    if(a[0]==b[0])
        return a[1]<b[1];
    return a[0]>b[0];
}

class Solution {
public:
    int numberOfWeakCharacters(vector<vector<int>>& p) {
        int weak=0;
        sort(p.begin(),p.end(),comp);   //sort p according to first value (attacks) and if 2 have same attack make sure that the one
                                        //with weak defence come first to make sure that it don't update ans/weak
        int defence=INT_MIN;
        for(int i=0;i<p.size();i++)
        {
            if(defence>p[i][1])
                weak++;
            defence=max(defence,p[i][1]);
        }
        return weak;
    }
};