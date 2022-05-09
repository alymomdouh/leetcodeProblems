function letterCombinations(digits: string): string[] {
 let str = ["", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz"];
    let vector = [];
 
    if (digits.length == 0)
        return vector;
    else if (digits.length == 1) {
        if (digits[0] == '2')
            return ["a", "b", "c"];
        else if (digits[0] == '3')
            return ["d", "e", "f"];
        else if (digits[0] == '4')
            return ["g", "h", "i"];
        else if (digits[0] == '5')
            return ["j", "k", "l"];
        else if (digits[0] == '6')
            return ["m", "n", "o"];
        else if (digits[0] == '7')
            return ["p", "q", "r", "s"];
        else if (digits[0] == '8')
            return ["t", "u", "v"];
        else if (digits[0] == '9')
            return ["w", "x", "y", "z"];
    } else {
 
        let digit1 = letterCombinations(digits.slice(0, 1));
 
        let digit2 = letterCombinations(digits.slice(1, digits.length));
 
        for (let it1 of digit1)
            for (let it2 of digit2)
                vector.push(it1 + it2);
        return vector;
    }
};