// O(N*M^2) time
// N: size of array
// M: length of word

// class Solution {
//     fun longestStrChain(words: Array<String>): Int {
//         // sort by length of string with descending order
//         words.sortBy { -it.length }
        
//         val size = words.size
//         // <word, length of chain>
//         val table = mutableMapOf<String, Int>()
//         val sb = StringBuilder()
//         var answer = 0
        
//         for (i in 0 until size) {
//             // get pre-stored length of chain
//             val chain = table[words[i]] ?: 0            
//             val length = words[i].length
            
//             // store a word which is removed each indexed charachter
//             for (j in 0 until length) {
//                 for (k in 0 until length) {
//                     if (j != k) sb.append(words[i][k])
//                 }
//                 // keep maximum value
//                 val temp = table[sb.toString()] ?: 0
//                 table[sb.toString()] = maxOf(temp, chain + 1)
//                 // get longest length of chain
//                 answer = maxOf(answer, chain + 1)
//                 sb.clear()
//             }
//         }
//         return answer
//     }
// }

//O(N*M) time

class Solution {
    fun longestStrChain(words: Array<String>): Int {
        words.sortBy { it.length } // sort by length of string with ascending order
        
        val size = words.size
        val table = mutableMapOf<String, Int>() // <word, length of chain>
        val sb = StringBuilder()
        var answer = 0
        
        words.forEach { word ->
            table[word] = 1 // at least 1 chain
            sb.insert(0, word)
            word.forEachIndexed { index, c ->
                val deletedChar = sb[index]
                sb.deleteCharAt(index) // delete each indexed character
                
                val prev = table[sb.toString()] ?: 0 // get chain of deleted word
                val curr = table[word]!!
                table[word] = maxOf(prev + 1, curr) // store longest word chain
                sb.insert(index, deletedChar) // recover string builder
            }
            answer = maxOf(answer, table[word]!!) // get longest word chain
            sb.clear()
        }
        return answer
    }
}

///without StringBuilder

// class Solution {
//     fun longestStrChain(words: Array<String>): Int {
//         words.sortBy { it.length } // sort by length of string with ascending order
        
//         val size = words.size
//         val table = mutableMapOf<String, Int>() // <word, length of chain>
//         var answer = 0
        
//         words.forEach { word ->
//             var chain = 0
//             for (i in word.indices) {
//                 val prev = word.substring(0, i) + word.substring(i + 1) 
//                 // deleted one character
//                 val temp = table[prev] ?: 0
//                 chain = maxOf(chain, temp + 1)
//             }
//             table[word] = chain // store chain of current word
//             answer = maxOf(answer, chain)
//         }
//         return answer
//     }
// }