function sortArrayByParity(nums: number[]): number[] {
   let evennums: number[]=[];   
   let oddnums: number[]=[];
     for(let i=0;i<nums.length;i++){
         if(nums[i]%2==0){
           evennums.push(nums[i]);
         }else{
           oddnums.push(nums[i]); 
         }
     }
 return [...evennums,...oddnums]
};