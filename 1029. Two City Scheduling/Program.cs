public class Solution
{
    public int TwoCitySchedCost(int[][] costs)
    {
        var n = costs.Length / 2;
        var costToA = 0;
        var diffArray = new int[n * 2];
        for (int i = 0; i < n * 2; i++)
        {
            costToA += costs[i][0];
            diffArray[i] = costs[i][1] - costs[i][0];
        }
        Array.Sort(diffArray);
        for (int i = 0; i < n; i++)
        {
            costToA += diffArray[i];
        }
        return costToA;
    }
}
