public class Solution {
    public string MinWindow(string s, string t) {

        if (t.Count()==0) {
            return "";
        }

        // initialize the results
        var resLeft=0;
        var resLen=Int32.MaxValue;

        // initialise the count dictionary (values to match)
        var count = new int[256];
        var need=0;
        foreach (var c in t) {
            count[c]++;
            need++;
        }

        // initialise the window dictionary (record of matches values)
        var window = new int[256];
        var have=0;

        var left=0;
        for(var right=0; right<s.Count(); right++) {
            var cr=s[right];
            window[cr]++;
            
            // check if we have met the condition
            if (window[cr] <= count[cr]) {
                have++;
            }

            // try to shrink
            while (have==need && left <= right) {
                var windowLen=right-left+1;
                if ( windowLen < resLen) {
                    resLeft=left;
                    resLen=windowLen;
                }

                var cl=s[left];
                if (count[cl] > 0) {
                    window[cl]--;
                    if (window[cl] < count[cl]) {
                        have--;
                    }
                }
                
                left++;
            }
        }

        return resLen == Int32.MaxValue ? "" : s.Substring(resLeft, resLen);
    }
}
