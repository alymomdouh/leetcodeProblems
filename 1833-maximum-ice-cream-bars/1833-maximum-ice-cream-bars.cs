/*
public class Solution {
   public int MaxIceCream(int[] costs, int coins)
    {
        var count = 0;

        // Calculate whether O(n log n) solution would be
        // faster than O(n) solution
        if (costs.Length * Math.Log(costs.Length, 2) < coins)
        {
            Array.Sort(costs);
            foreach (var cost in costs)
            {
                if (coins < cost)
                    break;

                coins -= cost;
                count++;
            }
        }
        else
        {
            var d = new Dictionary<int, int>();
            foreach (var cost in costs)
            {
                if (d.TryGetValue(cost, out var val))
                    d[cost] = val + 1;
                else
                    d[cost] = 1;
            }

            for (int icCost = 1; icCost <= coins; icCost++)
            {
                if (d.TryGetValue(icCost, out var numIceCreams))
                {
                    while (numIceCreams > 0 && coins - icCost >= 0)
                    {
                        count++;
                        coins -= icCost;
                        numIceCreams--;
                    }
                }
            }
        }
        return count; 
    }
}
*/

public class Solution
  {
    public int MaxIceCream(int[] costs, int coins)
    {
      Array.Sort(costs);

      var ans = 0;
      var index = 0;

      while (coins > 0)
      {
        if (index == costs.Length)
          break;

        if (costs[index] <= coins)
        {
          ans++;
          coins -= costs[index];
          index++;
          continue;
        }

        break;
      }

      return ans;
    }
  }