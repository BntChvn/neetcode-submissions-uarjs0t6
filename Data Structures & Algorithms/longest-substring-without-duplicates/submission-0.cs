public class Solution {
    public int LengthOfLongestSubstring(string s) {

        // s length
        var n=s.Count();
        
        // two pointers
        var start=0;
        var end=0;
        
        // return value
        var max=0;
        
        while (start<n && end <n && start<=end) {
            var idx=s.IndexOf(s[end], start);
            if (idx==end) {
                end++;
                max=Math.Max(max, end-start);
            }
            else
            {
                start=idx+1;
            }
        }

        return max;
    }
}
