/*
using System;
using System.Collections.Generic;
public class Solution {
    public Func<int[], bool> ContainsDuplicate = (nums) => (new HashSet<int>(nums)).Count != nums.Length;
}
*/
/*
public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        if (nums == null || nums.Length == 0) return false;
        HashSet<int> set = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++) {
            // return ture when meet duplictes
            if (!set.Add(nums[i])) return true;
        }
        return false;
    }
}
*/
/*
using System.Linq;
public partial class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        return nums.Distinct().Count() < nums.Length;
    }
}
*/
public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var digits = new HashSet<int>();
        for(int i = 0; i < nums.Length; i++){
            if(digits.Contains(nums[i]))
                return true; 
            digits.Add(nums[i]); 
        } 
        return false;
    }
}