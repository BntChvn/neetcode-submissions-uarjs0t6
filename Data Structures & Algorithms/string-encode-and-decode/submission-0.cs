public class Solution {

    public string Encode(IList<string> strs) {
        var sb = new StringBuilder();

        foreach (var str in strs) {
            sb.Append($"{str.Count()}#{str}");
        }

        return sb.ToString();
    }

    public List<string> Decode(string s) {
        var output = new List<string>();
        var curr=0;
        while(curr<s.Count()) {
            var sep_id = s.IndexOf("#", curr);
            if (Int32.TryParse(s.Substring(curr, sep_id-curr), out var length))
            {
                var str = s.Substring(sep_id+1, length);
                output.Add(str);

                curr=sep_id+length+1;
            }
            else
            {
                return output;
            }
        }

        return output;
   }
}
