
// var RandomizedSet = function() {
    
// };

// /** 
//  * @param {number} val
//  * @return {boolean}
//  */
// RandomizedSet.prototype.insert = function(val) {
    
// };

// /** 
//  * @param {number} val
//  * @return {boolean}
//  */
// RandomizedSet.prototype.remove = function(val) {
    
// };

// /**
//  * @return {number}
//  */
// RandomizedSet.prototype.getRandom = function() {
    
// };

/** 
 * Your RandomizedSet object will be instantiated and called as such:
 * var obj = new RandomizedSet()
 * var param_1 = obj.insert(val)
 * var param_2 = obj.remove(val)
 * var param_3 = obj.getRandom()
 */
class RandomizedSet {
  /**
   * Initialize your data structure here.
   */
  constructor() {
    this.nums = [];
    this.pos = {};
  }

  /**
   * Inserts a value to the set. Returns true if the set did not already contain the specified element.
   * @param {number} val
   * @return {boolean}
   */
  insert(val) {
    if (this.pos[val] != null) return false;

    this.nums.push(val);
    this.pos[val] = this.nums.length - 1;
    return true;
  }

  /**
   * Removes a value from the set. Returns true if the set contained the specified element.
   * @param {number} val
   * @return {boolean}
   */
  remove(val) {
    if (this.pos[val] == null) return false;

    const i = this.pos[val];
    const lastNum = this.nums[this.nums.length - 1];

    // Swap the last num with val
    this.nums[i] = lastNum;
    this.pos[lastNum] = i;

    // Remove val
    this.nums.pop();
    delete this.pos[val];

    return true;
  }

  /**
   * Get a random element from the set.
   * @return {number}
   */
  getRandom() {
    const i = ~~(Math.random() * this.nums.length);
    return this.nums[i]
  }
}