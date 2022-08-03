// solation by loop and array 

// function containsDuplicate(nums: number[]): boolean {
//     nums.sort((n1,n2) => n1 - n2);
//     for(let i=0;i<nums.length;i++){
//         if(nums[i]===nums[i+1]){
//            return true
//            }
//     }
//     return false
// };

/// best solation 
function containsDuplicate(nums: number[]): boolean {
    if(nums.length<2){
       return false;
       }
     let resmap: number[]=[]; 
      for(let i=0;i<nums.length;i++){
         if(resmap.some(x => x ===nums[i])){
             return true
             }else{
                 resmap.push(nums[i]);
             }
      }
      return false
};
 