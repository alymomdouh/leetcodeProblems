/**
Approach #1: Hash Set [Accepted]
Intuition and Algorithm
We can transform each word into it's Morse Code representation.
After, we put all transformations into a set seen, and return the size of the set.
Java

Complexity Analysis
Time Complexity: O(S), where S is the sum of the lengths of words in words. We iterate through each character of each word in words.
Space Complexity: O(S).
**/
class Solution {
    public int uniqueMorseRepresentations(String[] words) {
        String[] MORSE = new String[]{".-","-...","-.-.","-..",".","..-.","--.",
                         "....","..",".---","-.-",".-..","--","-.",
                         "---",".--.","--.-",".-.","...","-","..-",
                         "...-",".--","-..-","-.--","--.."};
        Set<String> seen = new HashSet();
        for (String word: words) {
            StringBuilder code = new StringBuilder();
            for (char c: word.toCharArray())
                code.append(MORSE[c - 'a']);
            seen.add(code.toString());
        }
        return seen.size();
    }
}
//Your runtime beats 85.31 % of cpp submissions.
