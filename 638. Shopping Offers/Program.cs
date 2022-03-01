public class Solution
{
    public int ShoppingOffers(IList<int> price, IList<IList<int>> special, IList<int> needs)
    {
        var n = price.Count;

        var res = 0;

        for (int i = 0; i < n; i++)
        {
            res += price[i] * needs[i];
        }

        for (int i = 0; i < special.Count; i++)
        {
            var isSpecialAccept = true;
            var newNeeds = new int[n];
            for (int j = 0; j < n; j++)
            {
                var need = needs[j] - special[i][j];
                if (need >= 0)
                {
                    newNeeds[j] = need;
                }
                else
                {
                    isSpecialAccept = false;
                    break;
                }
            }

            if (isSpecialAccept)
            {
                var specialRes = special[i][n] + ShoppingOffers(price, special, newNeeds.ToList());
                res = Math.Min(res, specialRes);
            }
        }

        return res;
    }
}