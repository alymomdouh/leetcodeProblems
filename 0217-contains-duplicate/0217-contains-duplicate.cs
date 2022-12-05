using System;
using System.Collections.Generic;

public class Solution {
    public Func<int[], bool> ContainsDuplicate = (nums) => (new HashSet<int>(nums)).Count != nums.Length;
}