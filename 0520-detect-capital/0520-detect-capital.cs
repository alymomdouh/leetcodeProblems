/*
using System.Text.RegularExpressions;
public class Solution {

    private static readonly Regex Pattern = new Regex(@"^[A-Z]?(([a-z]+)|([A-Z]+))$", RegexOptions.Compiled);

    public bool DetectCapitalUse(string word) {
        return Pattern.IsMatch(word);
    }
}
*/
public class Solution {
    public bool DetectCapitalUse (string word) {
        bool fg = false;
        int count = 0;
        for (int i = 0; i < word.Length; i++) {
            char c = word[i];
            if (i == 0) {
                if (c >= 'A' && c <= 'Z') {
                    fg = true;
                    count++;
                } else {
                    fg = false;
                }
            } else {
                if (fg) {
                    if (c >= 'A' && c <= 'Z') {
                        count++;
                    }
                } else {
                    if (c >= 'A' && c <= 'Z') {
                        return false;
                    }
                }
            }
        }
        return (count == 0 || count == 1 || count == word.Length);
    }
}