public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var map = new Dictionary<string, List<string>>();

        foreach (var str in strs) {
            var key = String.Concat(str.OrderBy(c => c));
            if (map.TryGetValue(key, out var list)) {
                list.Add(str);
                continue;
            }

            map.Add(key, new List<string>() {str});
        }

        return map.Select(kvp => kvp.Value).ToList();
    }
}
