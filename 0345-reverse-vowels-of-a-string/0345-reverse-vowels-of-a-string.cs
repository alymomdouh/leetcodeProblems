public class Solution {
    static bool isVowel(char c)
    {
        return (c == 'a' || c == 'A' || c == 'e'
                || c == 'E' || c == 'i' || c == 'I'
                || c == 'o' || c == 'O' || c == 'u'
                || c == 'U');
    }
    public string ReverseVowels(string str1) {
        int j = 0;
         
        // Storing the vowels separately
        char[] str = str1.ToCharArray();
        String vowel = "";
        for (int i = 0; i < str.Length; i++)
        {
            if (isVowel(str[i]))
            {
                j++;
                vowel += str[i];
            }
        }
 
        // Placing the vowels in the reverse
        // order in the string
        for (int i = 0; i < str.Length; i++)
        {
            if (isVowel(str[i]))
            {
                str[i] = vowel[--j];
            }
        }
 
        return String.Join("",str);
    }
}
