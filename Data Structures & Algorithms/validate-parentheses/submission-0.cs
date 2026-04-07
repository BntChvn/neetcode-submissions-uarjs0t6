public class Solution {
    public bool IsValid(string s) {
        var open = new HashSet<char>() {'(', '[', '{'};
        var close = new HashSet<char>() {')', ']', '}'};
        var acc = new Stack<char>();

        foreach(var c in s) {
            if (open.Contains(c)) {
                acc.Push(c);
            }

            if (close.Contains(c)) {
                if (acc.Any()) {
                    switch(c) {
                        case ')':
                            if (acc.Peek() != '(') {
                                return false;
                            }
                            acc.Pop();
                            break;
                        case ']':
                            if (acc.Peek() != '[') {
                                return false;
                            }
                            acc.Pop();
                            break;
                        case '}':
                            if (acc.Peek() != '{') {
                                return false;
                            }
                            acc.Pop();
                            break;
                    }
                }
                else
                {
                    // closing character without opened one
                    return false;
                }
            }

        }

        if (acc.Any()) {
            // opening character without closing one
            return false;
        }
        
        return true;
    }
}
