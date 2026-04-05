public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        // create a dictionary of value => indexes
        var map = new Dictionary<int, List<int>>();

        for(var i=0; i<nums.Count(); i++) {
            var n = nums[i];
            if (map.TryGetValue(n, out var list)) {
                list.Add(i);
            }
            else {
                map.Add(n, new List<int>() {i});
            }
        }

        foreach (var kvp in map) {
            var t = target-kvp.Key;

            if (t == kvp.Key) {
                if (kvp.Value.Count >= 2) {
                    return new int[2] {kvp.Value[0], kvp.Value[1]};    
                }
                continue;
            }

            if (map.TryGetValue(t, out var list)) {
                return new int[2] {kvp.Value[0], list[0]};
            }
        }

        return new int[0];
    }
}
