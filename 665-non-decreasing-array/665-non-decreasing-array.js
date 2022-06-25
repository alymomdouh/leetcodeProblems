/**
 * @param {number[]} nums
 * @return {boolean}
 */
var checkPossibility = function(N) {
    for (let i = 1, err = 0; i < N.length; i++)
        if (N[i] < N[i-1])
            if (err++ || (i > 1 && i < N.length - 1 && N[i-2] > N[i] && N[i+1] < N[i-1]))
                return false 
    return true
};