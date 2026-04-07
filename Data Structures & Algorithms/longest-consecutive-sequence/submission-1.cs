public class Solution {
    public int LongestConsecutive(int[] nums) {
        var set = new HashSet<int>();
        foreach(var n in nums) {
            if (set.Contains(n)) continue;
            set.Add(n);
        }

        var starts=new List<int>();
        foreach(var n in nums) {
            if(!set.Contains(n-1)) {
                starts.Add(n);
            }
        }
        
        var max=0;
        foreach(var start in starts) {
            var count=0;
            var target=start;
            while(set.Contains(target)) {
                target++;
                count++;
                max=Math.Max(max, count);
            }
        }

        return max;
    }
}
