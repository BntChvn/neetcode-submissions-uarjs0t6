public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var frequencies = new Dictionary<int,int>();
        foreach(var n in nums) {
            if(frequencies.ContainsKey(n)) {
                frequencies[n] += 1;
                continue;
            }

            frequencies.Add(n, 1);
        }

        return frequencies
            .OrderByDescending(kvp => kvp.Value)
            .Take(k)
            .Select(kvp => kvp.Key)
                .ToArray(); 

    }
}
