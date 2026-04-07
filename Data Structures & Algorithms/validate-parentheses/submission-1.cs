public class Solution {
    public bool IsValid(string s) {
        var open = new HashSet<char>() {'(', '[', '{'};
        var map = new Dictionary<char, char>
        {
            { ')', '(' },
            { ']', '[' },
            { '}', '{' }
        };

        var stack = new Stack<char>();

        foreach(var c in s) {
            if (open.Contains(c))
            {
                stack.Push(c);
            }
            else if (map.ContainsKey(c)) {
                if (stack.Count == 0 || stack.Pop() != map[c])
                    return false;
            }

        }
       
        return stack.Count == 0;
    }
}
