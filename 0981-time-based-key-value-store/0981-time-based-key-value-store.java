// class TimeMap {

//     public TimeMap() {
        
//     }
    
//     public void set(String key, String value, int timestamp) {
        
//     }
    
//     public String get(String key, int timestamp) {
        
//     }
// }
   

// Time: Constructor: O(1)O(1), set(key: str, value: str, timestamp: int): O(1)O(1), get(key: str, timestamp: int): O(\log n)O(logn), where n = |\texttt{map[key]}|n=∣map[key]∣
// Space: O(|\texttt{set(key: str, value: str, timestamp: int)}|)O(∣set(key: str, value: str, timestamp: int)∣)

/**
 * Your TimeMap object will be instantiated and called as such:
 * TimeMap obj = new TimeMap();
 * obj.set(key,value,timestamp);
 * String param_2 = obj.get(key,timestamp);
 */
class T {
  public String value;
  public int timestamp;
  public T(String value, int timestamp) {
    this.value = value;
    this.timestamp = timestamp;
  }
}

class TimeMap {
  public void set(String key, String value, int timestamp) {
    map.putIfAbsent(key, new ArrayList<>());
    map.get(key).add(new T(value, timestamp));
  }

  public String get(String key, int timestamp) {
    List<T> A = map.get(key);
    if (A == null)
      return "";

    int l = 0;
    int r = A.size();

    while (l < r) {
      final int m = (l + r) / 2;
      if (A.get(m).timestamp > timestamp)
        r = m;
      else
        l = m + 1;
    }

    return l == 0 ? "" : A.get(l - 1).value;
  }

  private Map<String, List<T>> map = new HashMap<>();
}
