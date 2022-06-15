class Solution {
    fun longestStrChain(words: Array<String>): Int {
        // sort by length of string with descending order
        words.sortBy { -it.length }
        
        val size = words.size
        // <word, length of chain>
        val table = mutableMapOf<String, Int>()
        val sb = StringBuilder()
        var answer = 0
        
        for (i in 0 until size) {
            // get pre-stored length of chain
            val chain = table[words[i]] ?: 0            
            val length = words[i].length
            
            // store a word which is removed each indexed charachter
            for (j in 0 until length) {
                for (k in 0 until length) {
                    if (j != k) sb.append(words[i][k])
                }
                // keep maximum value
                val temp = table[sb.toString()] ?: 0
                table[sb.toString()] = maxOf(temp, chain + 1)
                // get longest length of chain
                answer = maxOf(answer, chain + 1)
                sb.clear()
            }
        }
        return answer
    }
}