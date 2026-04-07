public class Solution {
    public int LengthOfLongestSubstring(string s) {

        // two pointers
        var start=0;
        var end=0;
        
        // return value
        var max=0;
        
        while (start<s.Count() && end<s.Count() && start<=end) {
            var idx=s.IndexOf(s[end], start);
            if (idx==end)
            {
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
