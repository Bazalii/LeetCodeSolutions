public class Solution 
{
    public bool IsValid(string s) 
    {
        if (s.Length == 1)
            return false;
        var stack = new Stack<char>();
        foreach (var elem in s)
        {
            if (elem == '(' || elem == '{' || elem == '[')
                stack.Push(elem);
            else
            {
                if (stack.Count == 0) 
                    return false;
                var value = stack.Pop();
                if (elem == ')' && value != '(')
                    return false;
                if (elem == '}' && value != '{')
                    return false;
                if (elem == ']' && value != '[')
                    return false;
            }   
        }
        
        return stack.Count == 0;
    }
}