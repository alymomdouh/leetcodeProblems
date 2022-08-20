class Solution {    
public:
    int minRefuelStops(int target, int startFuel, vector<vector<int>>& stations) {

        priority_queue<int> candidates; // maxinum heap

        int stops = 0;
        int cursor = 0;
        int distance = startFuel;

        while (distance < target) {
            while (cursor < stations.size() && stations[cursor][0] <= distance) {
                candidates.push(stations[cursor++][1]);
            }
            if (candidates.empty()) 
                return -1;

            distance += candidates.top();
            candidates.pop();
            ++stops;
        }
        return stops;
    }
};