public class Solution 
{
    public int RomanToInt(string s) 
    {
        int answer = 0;
        int i = 0;
        for (i = s.Length - 1; i > 0; i--)
        {
            if (s[i] == 'V' && s[i - 1] == 'I')
            {
                answer += 4;
                i--;
            }
            else if (s[i] == 'X' && s[i - 1] == 'I')
            {
                answer += 9;
                i--;
            } 
            else if (s[i] == 'L' && s[i - 1] == 'X')
            {
                answer += 40;
                i--;
            }  
            else if (s[i] == 'C' && s[i - 1] == 'X')
            {
                answer += 90;
                i--;
            }  
            else if (s[i] == 'D' && s[i - 1] == 'C')
            {
                answer += 400;
                i--;
            } 
            else if (s[i] == 'M' && s[i - 1] == 'C')
            {
                answer += 900;
                i--;
            } 
            else if(s[i] == 'I')
                answer += 1;
            else if(s[i] == 'V')
                answer += 5;
            else if(s[i] == 'X')
                answer += 10;
            else if(s[i] == 'L')
                answer += 50;
            else if(s[i] == 'C')
                answer += 100;
            else if(s[i] == 'D')
                answer += 500;
            else if(s[i] == 'M')
                answer += 1000;
        }
        if (i < 0)
            return answer;
        if(s[0] == 'I')
            answer += 1;
        else if(s[0] == 'V')
            answer += 5;
        else if(s[0] == 'X')
            answer += 10;
        else if(s[0] == 'L')
            answer += 50;
        else if(s[0] == 'C')
            answer += 100;
        else if(s[0] == 'D')
            answer += 500;
        else if(s[0] == 'M')
            answer += 1000;
        return answer;
    }
}