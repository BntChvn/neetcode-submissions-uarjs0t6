public class Solution {
    public int[] ProductExceptSelf(int[] nums) {

        var N = nums.Count();
        var output = new int[N];

        int acc=1;
        for (int i=0; i<N; i++) {
            output[i] = acc;
            acc *= nums[i];
        }

        acc=1;
        for (int i=N-1; i>=0; i--) {
            output[i] *= acc;
            acc *= nums[i];
        }

        return output;
    }
}
