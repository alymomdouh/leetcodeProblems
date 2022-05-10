function combinationSum3(k: number, n: number): number[][] {
 if (k == 1)
        return [[n]];
    else if (k > n / 2)
        return [];
    else {
        let temp = [], res = [];
        combinationSum(1, k, n, temp, res);
        return res;
    }
};

var combinationSum = function (start, k, n, temp = [], res = []) {
    if (k < 0 || n < 0)
        return;
    else if (k == 0 && n == 0) {
        res.push([...temp]);
    }
    else
        for (let i = start; i <= 9; i++) {
            temp.push(i);
            combinationSum(i + 1, k - 1, n - i, temp, res);
            temp.pop();
        }
};