/*
 * @lc app=leetcode id=451 lang=csharp
 *
 * [451] Sort Characters By Frequency
 */

using System.Collections.Generic;
using System.Linq;

public class Solution {
    /*
    //soltion 1
    public string FrequencySort(string s) {
        IDictionary<char, int> count = new Dictionary<char, int>();
        foreach (char c in s) {
            count[c] = 1 + (count.ContainsKey(c) ? count[c] : 0);
        }
        return new string(s.OrderByDescending(c => (count[c], c)).ToArray());
    }
    */
    /*
    // soltion 2
     public string FrequencySort(string s) { 
           Dictionary<char, int> dic = new Dictionary<char, int>();
            foreach (var c in s)
            {
                if (dic.ContainsKey(c))
                {
                    dic[c]++;
                }
                else
                {
                    dic.Add(c, 1);
                }
            }
         return new string(s.OrderByDescending(c => (dic[c], c)).ToArray());
    }
    */
    // soltion 3
    public string FrequencySort(string s) { 
           Dictionary<char, int> dic = new Dictionary<char, int>();
            foreach (var c in s)
            {
                if (dic.ContainsKey(c))
                {
                    dic[c]++;
                }
                else
                {
                    dic.Add(c, 1);
                }
            }
          List<int[]> list = new List<int[]>();
            foreach (var kvp in dic)
            {
                int[] temp = new int[] { 0, 0};
                temp[0] = kvp.Key - 'a';
                temp[1] = kvp.Value;
                list.Add(temp);
            } 
            list.Sort((p1, p2) => p2[1] -p1[1]);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            foreach (var i in list)
            {
                for (int j = 0; j < i[1]; j++)
                {
                    sb.Append((char)(i[0] + 'a'));
                }
            }
            return sb.ToString();
    }
}
