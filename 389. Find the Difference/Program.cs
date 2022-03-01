public class Solution
{
    public char FindTheDifference(string s, string t)
    {
        int sum = 0;
        for (int i = 0; i < s.Length; i++)
        {
            sum -= s[i];
            sum += t[i];
        }
        sum += t[t.Length - 1];
        return (char)sum;
    }
}