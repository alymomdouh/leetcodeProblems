/*
public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int insertIndex = 1;
        for(int i = 1; i < nums.Length; i++){
    // We skip to next index if we see a duplicate element
            if(nums[i - 1] != nums[i]) {   
 //Storing the unique element at insertIndex index and //incrementing   the insertIndex by 1  
                nums[insertIndex] = nums[i];  
                insertIndex++;
            }
        }
        return insertIndex;
    }
}*/
public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int l=0,r=0;
        while(r<nums.Length){
            while((r+1 < nums.Length)&&(nums[r+1]==nums[r])){ 
                 r+=1;
            }
            nums[l]=nums[r];
            l+=1;
            r+=1;
        }
        return l;
    }
}