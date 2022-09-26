//Method 1: Union find set beats 100%
class Solution {
    private static final char EQ = '=';
    private static final char NOT_EQ = '!';
    private char[] uf;
    public boolean equationsPossible(String[] equations) {
        this.uf = new char[26];
        for(int i = 0; i < 26; i++) uf[i] = (char)(i + 'a');
        for(int i = 0; i < equations.length; i++){
            String eq = equations[i];
            if(eq.charAt(1) == EQ){ // Add to union find set
                union(eq.charAt(0), eq.charAt(3));
            }
        }
        for(int i = 0; i < equations.length; i++){
            String eq = equations[i];
            if(eq.charAt(1) == NOT_EQ){
                char a = find(eq.charAt(0));
                char b = find(eq.charAt(3));
                if(a == b) return false;
            }
        }
        return true;
    }
    private char find(char c){
        if(c != uf[c - 'a']){
            uf[c - 'a'] = find(uf[c - 'a']);
        }
        return uf[c - 'a'];
    }
    private void union(char a, char b){
        char p = find(a);
        char q = find(b);
        uf[p - 'a'] = q;
    }
}