public class Solution {
    public int FindMin(int[] nums) {
        // we are looking for the minimum value in an array that has been rotated a number or time
        // the original array contains unique values and is sorted

        // trivial case
        if (nums.Count() == 1) return nums[0];   

        var start=0;
        var end=nums.Count()-1;
        while (start<end) {

            // get the middle of the range
            var curr = start + (end-start)/2;

            // the range is sorted
            if (nums[curr] < nums[end]) {
                end=curr;
            }
            else
            {
                start=curr + 1;
            }
        }

        return nums[start];
    }
}
