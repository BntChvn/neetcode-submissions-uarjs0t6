public class Solution {
    public string MinWindow(string s, string t) {

        if (t.Count()==0) {
            return "";
        }

        // initialize the results
        var resLeft=0;
        var resLen=Int32.MaxValue;

        // initialise the count dictionary (values to match)
        var count = new Dictionary<char,int>();
        foreach (var c in t) {
            if (count.TryAdd(c, 1)) {
                continue;
            }
            count[c]++;
        }

        // initialise the window dictionary (record of matches values)
        var window = new Dictionary<char,int>();
        foreach(var k in count.Keys) {
            window.Add(k, 0);
        }

        var need=count.Values.Sum();
        var have=0;

        var left=0;
        for(var right=0; right<s.Count(); right++) {
            var cr=s[right];
            if (window.ContainsKey(cr)) {
                window[cr]++;
            }
            
            // check if we have met the condition
            if (count.ContainsKey(cr) && window[cr] <= count[cr]) {
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
                if (count.ContainsKey(cl)) {
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
