public class Solution {
    public bool IsUgly(int n) {
         bool flag = n > 0 ? true : false;
        while(n > 1 && flag){
            if(n%2 == 0){n /= 2;}
            else if(n%3 == 0){n /= 3;}
            else if(n%5 == 0){n /= 5;}
            else{flag = false;}
        }
        return flag;
         
    }
}