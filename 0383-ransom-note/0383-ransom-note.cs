public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        foreach (char c in ransomNote)
            {
                int index = magazine.IndexOf(c);

                if (index < 0)
                    return false;

                magazine = magazine.Remove(index, 1);
            }

            return true;
    }
}