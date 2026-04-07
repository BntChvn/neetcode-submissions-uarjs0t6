public class Solution {
    public int MaxArea(int[] heights) {
        var max=0;

        var start=0;
        var end=heights.Count()-1;

        while (start<end) {
            var local = (end-start) * Math.Min(heights[start], heights[end]);

            max=Math.Max(local, max);

            if (heights[start]<heights[end]) {
                start++;
            }
            else
            {
                end--;
            }
        }

        return max;
    }
}
