/*
public class Solution {
    public int MaximumBags(int[] capacity, int[] rocks, int additionalRocks) {
        var pq = new PriorityQueue<int, int>();

        for (int i = 0; i < capacity.Length; i++)
        {
            var rocksNeeded = capacity[i] - rocks[i];
            pq.Enqueue(rocksNeeded, rocksNeeded);
        }

        var count = 0;

        while (pq.Count > 0 && additionalRocks > 0)
        {
            var numRocks = pq.Dequeue();
            if (numRocks <= additionalRocks)
            {
                additionalRocks -= numRocks;
                count++;
            }
            else
            {
                break;
            }
        }

        return count;
    }
}
*/
public class Solution {
    public int MaximumBags(int[] capacity, int[] rocks, int additionalRocks) {
    var cr = Enumerable
        .Range(0, capacity.Length)
        .Select(i => (c: capacity[i], r: rocks[i]))
        .OrderBy(e => e.c - e.r)
        .ToArray();

      var ans = 0;

      for (var i = 0; i < capacity.Length; i++)
      {
        if (cr[i].c - cr[i].r <= additionalRocks)
        {
          ans++;
          additionalRocks -= (cr[i].c - cr[i].r);
        }
        else
        {
          break;
        }
      }

      return ans;
}
}