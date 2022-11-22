<h2><a href="https://leetcode.com/problems/perfect-squares/">279. Perfect Squares</a></h2><h3>Medium</h3><hr><div><p>Given an integer <code>n</code>, return <em>the least number of perfect square numbers that sum to</em> <code>n</code>.</p>

<p>A <strong>perfect square</strong> is an integer that is the square of an integer; in other words, it is the product of some integer with itself. For example, <code>1</code>, <code>4</code>, <code>9</code>, and <code>16</code> are perfect squares while <code>3</code> and <code>11</code> are not.</p>

<p>&nbsp;</p>
<p><strong class="example">Example 1:</strong></p>

<pre><strong>Input:</strong> n = 12
<strong>Output:</strong> 3
<strong>Explanation:</strong> 12 = 4 + 4 + 4.
</pre>

<p><strong class="example">Example 2:</strong></p>

<pre><strong>Input:</strong> n = 13
<strong>Output:</strong> 2
<strong>Explanation:</strong> 13 = 4 + 9.
</pre>

<p>&nbsp;</p>
<p><strong>Constraints:</strong></p>

<ul>
	<li><code>1 &lt;= n &lt;= 10<sup>4</sup></code></li>
</ul>
</div>

# <h3>Solution</h3>  <hr>  
#  Solution1: Dynamic Programming

Considering the subproblem in this problem, given `n`, `numSquares(n) = min{numSquares(n), numSquares(n-j*j)+1, numSquares(n-(j-1)*(j-1))+1, ..., numSquares(n - 1*1)+1}` s.t. `j*j<=n`.  

Based on the above recursion equation, we could make use of Dynamic programming cause this question satisfies the two requirements of DP:  
1. Overlapping subproblem   
2. Optimal substructure  

The overlapping subproblem lies in that in the above equation, we will consider the subproblems in the `min{}` part again and again. And optimal substructure lies in that the optimal solution to a subproblem ranging from `(n-j*j) to 1` can always make up the possible global optimal solution for `n`.  

As a result, we have the following implementation.  

Time complexity: `O(n*n^(1/2) + (n-1)*((n-1)^1/2 + ... + 1*1^1/2) = 2/5 * n^(5/2)`. This is generted using Euler–Maclaurin formula.  

Space complexity: `O(n)`.  

```Java
class Solution {
    public int numSquares(int n) {
        int[] dp = new int[n + 1];
        Arrays.fill(dp, Integer.MAX_VALUE);
        dp[0] = 0;
        
        for (int i = 1; i <= n; i++) {
            // try every possible j s.t. j*j<i
            for (int j = 1; j * j <= i; j++) {
                dp[i] = Math.min(dp[i], dp[i - j * j] + 1);
            }
        }
        
        return dp[n];
    }
}
```

# Solution2: BFS looking for shortest path

We can also view this question as a graph question if e treat each number from `1` to `n` as nodes. And there is an edge between two nodes `i` and `j` if and only if there exists and number `k` such that `i = j + k * k` or `j = i + k * k`, where `k*k ≤ i and k*k ≤ j`.  
Hence, if we abstract this question into searching shortest path in a graph, we can also solve this question via BFS because of its suitability for searching shortest path.  

Starts from `0`, at each level, we would search for the sum of current number and each number from `1*1` to `n*n` and check if the sum adds up to `n`, if so, we return the current level, otherwise we continue one level deeper. The following graph gives an example for the tree we search through given `n` as `5`. When we got the path `0+1+4` which is of length `2`, we know that we have get the shorest path, aka minimum number of perfect squares needed to sum up to `n`.  

```
                         0
                   /  /  |  \  \
                  1  4  9  16  25
     /  /  /  /   |
     1  4  0  16  25 ...
     ...              
```

Time complexity: `O(n^(n+1))` because in the worst case we can search `n + 1` level in depth (worst case the perfect squares are made up all by `1`s) from `0` and the tree can thus contains up to `n^(n+1)` nodes (`n^0 + n^1 + n^2 + ... + n^(n-1) + n^n`). 

Space complexity: `O(n^n)` because of the queue used to store each level we are iterating through.  

```Java
class Solution {
    public int numSquares(int n) {
        if (n <= 0) return 0;
        
        List<Integer> squares = new ArrayList<>();
        for (int i = 1; i <= n; i++) {
            squares.add(i * i);
        }
        
        int currCount = 0;
        Deque<Integer> deque = new ArrayDeque<>();
        deque.offer(0);
        while (!deque.isEmpty()) {
            currCount++;
            int currLen = deque.size();
            for (int i = 0; i < currLen; i++) {
                int tmp = deque.poll();
                for (int j = 0; j < squares.size(); j++) {
                    if (tmp + squares.get(j) == n) {
                        return currCount;
                    } else if (tmp + squares.get(j) < n) {
                        deque.offer(tmp + squares.get(j));
                    } else {
                        break;
                    }
                }
            }
        }
        
        return 0;
    }
}
```
