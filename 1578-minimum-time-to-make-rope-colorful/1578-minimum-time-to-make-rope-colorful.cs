public class Solution {
    public int MinCost(string colors, int[] neededTime) {
        
         if (colors.Length==0) { return 0; }
         char prev = colors[0];
         int ans = 0;
        for (int i=1; i<neededTime.Length; i++) 
           {  
              if(colors[i]==prev){
                int curr = Math.Min(neededTime[i], 
                                    neededTime[i-1]);
                  ans+=curr;
                  neededTime[i] = Math.Max(neededTime[i], neededTime[i-1]); 
              }else{
                  prev = colors[i];
              }
           }
          return ans;  
    }
}