/**
 * @param {number} dividend
 * @param {number} divisor
 * @return {number}
 */
var divide = function (dividend, divisor) {
 
    if (dividend == -2147483648 && divisor == -1)
        return 2147483647;
    else if (divisor == 1)
        return divisor > 0 ? dividend : -dividend;
    else {
 
        let a = Math.abs(dividend), b = Math.abs(divisor), counter = 0, flag = 0, temp = 0;
 
        while (a - b >= 0) {
 
            flag = 1, temp = b;
 
            while (temp <= a - temp) {
                temp += temp;
                flag += flag;
            }
 
            counter += flag;
            a -= temp;
        }
 
        return (dividend >= 0) == (divisor >= 0) ? counter : -counter;
    }
};