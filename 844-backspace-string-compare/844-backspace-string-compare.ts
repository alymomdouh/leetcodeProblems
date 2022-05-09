function backspaceCompare(s: string, t: string): boolean {
    //console.log("test")
    s=s.toLowerCase();
    t=t.toLowerCase();
    if(s.length>=1 && s.length<=200&& t.length>=1 && t.length<=200){
      var num1='',num2=''; 
      let arr:any=[];
      for(let i=0;i<s.length;i++){
        if(s[i]=="#"){
          arr.pop();
        }else{
          arr.push(s[i]);
        }
      } 
      num1=arr.join("").toString();
      arr=[];
      for(let i=0;i<t.length;i++){
        if(t[i]=="#"){
          arr.pop();
        }else{
          arr.push(t[i]);
        }
      } 
      num2=arr.join("").toString();
      arr=[];

      console.log(num1);
      console.log(num2);
       return num1==num2; 
       }else{
        return false;
    } 
};