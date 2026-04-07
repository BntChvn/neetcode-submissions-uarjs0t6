public class Solution {
    public int[] ProductExceptSelf(int[] nums) {

        var N = nums.Count();
        var prefixes = new int[N];
        var suffixes = new int[N];
        int acc=1;
        for (int i=0; i<N; i++) {
            prefixes[i] = acc;
            acc *= nums[i];
        }

        acc=1;
        for (int i=N-1; i>=0; i--) {
            suffixes[i] = acc;
            acc *= nums[i];
        }

        var output = new int[N];
        for (int i=0; i<N; i++) {
            output[i] = prefixes[i] * suffixes[i];
        }

        return output;
    }
}
