public class Solution {
    public string MinWindow(string s, string t) {

        // trivial case
        if (t.Count() > s.Count()) {
            return "";
        }

        var left=0;
        var right=0;

        // initialize the best
        var best="";

        var t_freq = new Dictionary<char,int>();
        foreach(var c in t) {
            if (t_freq.TryGetValue(c, out var count)) {
                t_freq[c]=count+1;
                continue;
            }

            t_freq.Add(c, 1);
        }

        

        while (left < s.Count()-t.Count()+1 && right<s.Count())
        {
            var window = s.Substring(left, right-left+1);
            var w_freq = new Dictionary<char,int>();

            foreach(var c in window) {
                if (w_freq.ContainsKey(c)) {
                    w_freq[c]++;
                }
                else {
                    w_freq.Add(c, 1);
                }
            }

            var contained=true;
            foreach(var kvp in t_freq) {
                if (w_freq.TryGetValue(kvp.Key, out var w_count)) {
                    if (w_count >= kvp.Value) {
                        continue;
                    }
                }
                contained=false;
            } 
            
            // evaluate the output
            if (contained) {
                if (best == "") {
                    best=window;
                }
                else if (best.Count() > window.Count()) {
                    best=window;
                }
            }

            if(!contained)
            {
                right++;
            }
            else
            {
                left++;
            }
        }

        return best;
    }
}
