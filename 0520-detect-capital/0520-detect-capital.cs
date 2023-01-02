using System.Text.RegularExpressions;
public class Solution {

    private static readonly Regex Pattern = new Regex(@"^[A-Z]?(([a-z]+)|([A-Z]+))$", RegexOptions.Compiled);

    public bool DetectCapitalUse(string word) {
        return Pattern.IsMatch(word);
    }
}