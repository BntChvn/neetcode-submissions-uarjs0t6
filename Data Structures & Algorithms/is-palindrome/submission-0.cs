public class Solution {
    public bool IsPalindrome(string s) {
        var valid="ABCDEFGHIJKLMNOPQRSTUVWXYZ" + 
                  "abcdefghijklmnopqrstuvwxyz" +
                  "0123456789";
        var left=0;
        var right=s.Count()-1;

        while (left < right) {
            while(left < right && -1 == valid.IndexOf(s[left])) {
                left++;
            }

            while(right > left && -1 == valid.IndexOf(s[right])) {
                right--;
            }

            if (!String.Equals($"{s[left]}", $"{s[right]}", StringComparison.OrdinalIgnoreCase)){
                return false;
            }
            
            left++;
            right--;
        }

        return true;
    }
}
