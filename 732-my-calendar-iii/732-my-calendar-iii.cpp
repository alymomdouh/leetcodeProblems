class MyCalendarThree {
public:
    MyCalendarThree() {
        
    }
    
    int book(int start, int end) {
        if (m.find(start) == m.end())
            m[start] = 0;
        if (m.find(end) == m.end())
            m[end] = 0;
        
        m[start] ++;
        m[end] --;
        map<int, int>::iterator iter;
        int count = 0;
        int res = 0;
        for (iter = m.begin(); iter!= m.end(); iter ++)
        {
            count += iter->second;
            res = max(res, count);
        }
        return res;
    }
    
    map<int, int> m;
};

/**
 * Your MyCalendarThree object will be instantiated and called as such:
 * MyCalendarThree* obj = new MyCalendarThree();
 * int param_1 = obj->book(start,end);
 */