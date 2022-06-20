/**
 * @param {string} s
 * @return {boolean}
 */
var isValid = function (s) {
  const obj = {
    "(": ")",
    "[": "]",
    "{": "}"
  };
  let stack = [];
  for (let i = 0; i < s.length; i++) {
    const current = s[i];
    if (obj[current]) {
      //console.log(obj[current]);
      stack.push(obj[current]);
    } else if (stack.pop() !== current) {
      //console.log(obj[current]);
      //console.log(current);
      return false;
    }
  }
  return stack.length === 0;
};
console.log(isValid("()[]{}"));
//isValid("()[{}");
