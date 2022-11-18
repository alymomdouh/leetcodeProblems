/*
Analysis
The brute-force solution is to check all prime factors of num. By examining prime factors, determining if the factor is a prime is costly.

Recursion
The idea is that if a number num has factors 2, 3, 5 remove the effect of these factors by division. For example, 21 has a factor 3, so we can determine if it is an ugly number by indirectly checking if 21 / 3 is an ugly number.
*/
public class Solution {
    // solution 1
    /*
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
    */
    // solution 2
     public bool IsUgly(int n) {
          if (n <= 0) return false;
          if (n == 1) return true;
          if (n % 2 == 0) return IsUgly(n / 2);
          if (n % 3 == 0) return IsUgly(n / 3);
          if (n % 5 == 0) return IsUgly(n / 5);
          return false;
     }
}