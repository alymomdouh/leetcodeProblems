
// var MinStack = function() {
    
// };

// /** 
//  * @param {number} val
//  * @return {void}
//  */
// MinStack.prototype.push = function(val) {
    
// };

// /**
//  * @return {void}
//  */
// MinStack.prototype.pop = function() {
    
// };

// /**
//  * @return {number}
//  */
// MinStack.prototype.top = function() {
    
// };

// /**
//  * @return {number}
//  */
// MinStack.prototype.getMin = function() {
    
// };

/** 
 * Your MinStack object will be instantiated and called as such:
 * var obj = new MinStack()
 * obj.push(val)
 * obj.pop()
 * var param_3 = obj.top()
 * var param_4 = obj.getMin()
 */

class MinStack {
  constructor() {
    this.stack = [];
    this.minstack = [];
  }
  push(item) {
    if (!this.stack.length) {
      this.minstack.push(item);
    } else {
      let min = Math.min(item, this.minstack[this.minstack.length - 1]);
      this.minstack.push(min);
    }
    this.stack.push(item);
  }
  pop(){
    this.stack.pop();
    this.minstack.pop();
  }
  top(){
    return this.stack[this.stack.length-1];
  }
  getMin(){
   return this.minstack[this.minstack.length-1];
  }
}
