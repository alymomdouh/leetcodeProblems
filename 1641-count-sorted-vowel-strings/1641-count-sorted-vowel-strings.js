/**
 * @param {number} n
 * @return {number}
 */
var countVowelStrings = function (n) {
 
    let arr = [1, 1, 1, 1, 1];
 
    while (--n) {
        for (let j = 3; j >= 0; j--) {
            arr[j] += arr[j + 1];
 
            if (j == 0)
                break;
        }
    }
 
    return arr[0] + arr[1] + arr[2] + arr[3] + arr[4];
 
};