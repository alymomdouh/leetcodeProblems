class  Solution {
public:
    bool isPossible(vector<int>& nums) {
        unordered_map<int, priority_queue<int, vector<int>, std::greater<int>>> tails;
        int num_3 = 0;
        for(int num:nums){
            if(!tails[num-1].empty()){
                int cnt = tails[num-1].top();
                tails[num-1].pop();
                tails[num].push(++cnt);
                if(cnt == 3)
                    num_3--;
            }
            else{
                tails[num].push(1);
                num_3++;
            }
        }
        return num_3==0;
    }
};