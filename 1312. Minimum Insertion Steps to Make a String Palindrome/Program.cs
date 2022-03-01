var test = "no";

var solution = new Solution();
var result = solution.MinInsertions(test);
Console.WriteLine(result);

public class Solution
{
    public int MinInsertions(string s)
    {
        var n = s.Length;
        var dp = new int[n + 1, n + 1];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                dp[i + 1, j + 1] = s[i] == s[n - 1 - j] ? dp[i, j] + 1 : Math.Max(dp[i, j + 1], dp[i + 1, j]);
            }
        }
        return n - dp[n, n];
    }
}
