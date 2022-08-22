  public class Solution {
//     private static final double epsilon = 10e-15;
 
//     public boolean isPowerOfFour(int num) {
//         if (num == 0)
//             return false;
//         double res = Math.log(num) / Math.log(4);
//         return Math.abs(res - Math.round(res)) < epsilon;
//     }
 
// other soluation
public boolean isPowerOfFour(int n) {
        if (n == 0)
            return false;
        if (n == 1)
            return true;
        if (n % 4 == 0)
            return isPowerOfFour(n / 4);
        return false;
    }
  }