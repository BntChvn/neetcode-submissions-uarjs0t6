public class Solution {
    public int CharacterReplacement(string s, int k) {
        var n=s.Count();
        var freq=new int[26];
        var left=0;
        var maxFreq=0;
        var output=0;

        for (var right=0; right<n; right++) {
            var idxR=s[right]-'A';
            freq[idxR]++;
            maxFreq=Math.Max(maxFreq, freq[idxR]);

            // we need to do more than k replacements to have all the same characters in the sliding window
            while ((right-left + 1) - maxFreq > k) {
                var idxL=s[left]-'A';
                freq[idxL]--;
                left++;

                maxFreq=freq.Max();
            }

            output = Math.Max(output, right - left + 1);
        }


        return output;
    }
}
