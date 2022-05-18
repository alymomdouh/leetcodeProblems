<h2><a href="https://leetcode.com/problems/critical-connections-in-a-network/">1192. Critical Connections in a Network</a></h2><h3>Hard</h3><hr><div><p>There are <code>n</code> servers numbered from <code>0</code> to <code>n - 1</code> connected by undirected server-to-server <code>connections</code> forming a network where <code>connections[i] = [a<sub>i</sub>, b<sub>i</sub>]</code> represents a connection between servers <code>a<sub>i</sub></code> and <code>b<sub>i</sub></code>. Any server can reach other servers directly or indirectly through the network.</p>

<p>A <em>critical connection</em> is a connection that, if removed, will make some servers unable to reach some other server.</p>

<p>Return all critical connections in the network in any order.</p>

<p>&nbsp;</p>
<p><strong>Example 1:</strong></p>
<img alt="" src="https://assets.leetcode.com/uploads/2019/09/03/1537_ex1_2.png" style="width: 198px; height: 248px;">
<pre><strong>Input:</strong> n = 4, connections = [[0,1],[1,2],[2,0],[1,3]]
<strong>Output:</strong> [[1,3]]
<strong>Explanation:</strong> [[3,1]] is also accepted.
</pre>

<p><strong>Example 2:</strong></p>

<pre><strong>Input:</strong> n = 2, connections = [[0,1]]
<strong>Output:</strong> [[0,1]]
</pre>

<p>&nbsp;</p>
<p><strong>Constraints:</strong></p>

<ul>
	<li><code>2 &lt;= n &lt;= 10<sup>5</sup></code></li>
	<li><code>n - 1 &lt;= connections.length &lt;= 10<sup>5</sup></code></li>
	<li><code>0 &lt;= a<sub>i</sub>, b<sub>i</sub> &lt;= n - 1</code></li>
	<li><code>a<sub>i</sub> != b<sub>i</sub></code></li>
	<li>There are no repeated connections.</li>
</ul>
</div>
Leetcode Problem #1192 (Hard): Critical Connections in a Network
Description:

(Jump to: Solution Idea || Code: JavaScript | Python | Java | C++)

There are n servers numbered from 0 to n-1 connected by undirected server-to-server connections forming a network where connections[i] = [a, b] represents a connection between servers a and b. Any server can reach any other server directly or indirectly through the network.

A critical connection is a connection that, if removed, will make some server unable to reach some other server.

Return all critical connections in the network in any order.

Examples:
Example 1:	
Input:	n = 4, connections = [[0,1],[1,2],[2,0],[1,3]]
Output:	[[1,3]]
Explanation:	[[3,1]] is also accepted.
Visual:	Example 1 Visual
Constraints:
1 <= n <= 10^5
n-1 <= connections.length <= 10^5
connections[i][0] != connections[i][1]
There are no repeated connections.
Idea:

(Jump to: Problem Description || Code: JavaScript | Python | Java | C++)

If we think of the network and its connections like an undirected graph and its edges, then a critical connection, as defined by this problem, is the same as a bridge in the graph. To find out which edges are bridges, we can employ Tarjan's Bridge-Finding Algorithm (TBFA).

TBFA is a bit like a combination of a depth-first search (DFS) approach with recursion and a union-find. IN TBFA, we do a recursive DFS on our graph and for each node we keep track of the earliest node that we can circle back around to reach. By doing this, we can identify whether a given edge is a bridge because the far node doesn't lead back to any other earlier node.

To implement our TBFA, the first thing we have to do is to construct an edge map (edgeMap) from the connections list. Each key in our edge map should correspond to a specific node, and its value should be an array of each adjacent node to the key node.

We'll also need separate arrays to store the discovery time (disc) and the lowest future node (low) for each node, as well as a time counter to use with disc.

For our recursive DFS helper (dfs), each newly-visited node should set its initial value for both disc and low to the current value of time before time is incremented. (Note: If we start time at 1 instead of 0, we can use either disc or low as a visited array, rather than having to keep a separate array for the purpose. Any non-zero value in the chosen array will then represent a visited state for the given node.)

Then we recursively call dfs on each of the unvisited adjacent nodes (next) of the current node (curr). If one of the possible next nodes is an earlier node (disc[next] < curr[low]), then we've found a loop and we should update the low value for the current node. As each layer of the recursive function backtracks, it will propagate this value of low back down the chain.

If, after backtracking, the value of low[next] is still higher than low[curr], then there is no looped connection, meaning that the edge between curr and next is a bridge, so we should add it to our answer array (ans).

Once the dfs helper function has completed its traversal, we can return ans.

Implementation:
Javascript strangely runs significantly faster with a regular object rather than a Map().

