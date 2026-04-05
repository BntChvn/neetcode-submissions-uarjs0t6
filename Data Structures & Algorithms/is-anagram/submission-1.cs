public class Solution {
    public bool IsAnagram(string s, string t) {
        int[] count_s = new int[26];
        int[] count_t = new int[26];

        foreach(var c in s) {
            int idx = c-'a';
            count_s[idx] +=1;
        }

        foreach(var c in t) {
            int idx = c-'a';
            count_t[idx] +=1;
        }

        for(int i=0; i<26; i++) {
            if(count_s[i] != count_t[i]) {
                return false;
            }
        }

        return true;
    }
}
