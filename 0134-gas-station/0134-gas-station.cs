/*
public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        int totalGas = 0, remainingGas = 0, start = 0;
        for (int i = 0; i < gas.Length; ++i) {
            int diff = gas[i] - cost[i];
            totalGas += diff;
            remainingGas += diff;
            if (remainingGas < 0) {
                remainingGas = 0;
                start = i + 1;
            }
        }
        return totalGas < 0 ? -1 : start;
    }
}
*/

 public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        if (gas.Length == 0) return -1;
        var startIndex = 0;
        var i = 0;
        var gasLeft = 0;
        while (true)
        {
            gasLeft += gas[i] - cost[i];
            ++i;
            if (i >= gas.Length) i = 0;
            if (gasLeft < 0)
            {
                if (startIndex >= i)
                {
                    return -1;
                }
                startIndex = i;
                gasLeft = 0;
            }
            else
            {
                if (startIndex == i)
                {
                    return startIndex;
                }
            }
        }
    }
}