// Stack solution
// Time: O(n), 1ms
// Space: O(n), 34.1mb
class Solution {
    public boolean isValid(String s) {
        Deque<Character> stack = new ArrayDeque<>();
        
        for(int i = 0; i < s.length(); i++) {
            // Push the left parenthesis into stack
            if(s.charAt(i) == '(' || s.charAt(i) == '[' || s.charAt(i) == '{' ) {
                stack.push(s.charAt(i));
                
            } else {
                // When meet a right parenthesis compare with the top of the stack
                if(!stack.isEmpty()) {
                    char c = stack.pop();
                    if((c == '(' && s.charAt(i) == ')') || 
                      (c == '[' && s.charAt(i) == ']') ||
                      (c == '{' && s.charAt(i) == '}')) continue;
                }
                return false;
            }
        }
        
        return stack.isEmpty();
    }
}