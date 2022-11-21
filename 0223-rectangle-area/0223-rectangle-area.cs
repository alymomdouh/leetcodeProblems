public class Solution {
//     public int ComputeArea(int ax1, int ay1, int ax2, int ay2, int bx1, int by1, int bx2, int by2) {
        
//     }
   public int ComputeArea(int A, int B, int C, int D, int E, int F, int G, int H) {
        int areaA = (C-A) * (D-B);
        int areaB = (G-E) * (H-F);
        int coveredArea = 0;
        if ( !(E >= C || G <=A || H <= B || F >= D) ){
            coveredArea = ( Math.Min(C,G) - Math.Max(A,E)  ) * ( Math.Min(D,H) - Math.Max(B,F) );
        }
        
        return areaA + areaB - coveredArea;
    }
}