
public static class Change
{
    public static int[] FindFewestCoins(int[] coins, int target)
    {
        if(target == 0) return Array.Empty<int>();
        if(target < coins[0]) throw new ArgumentException("Target is too low for given coins.");

        int[][] best = new int[target+1][];
        best[0] = Array.Empty<int>();

        for (int amount = 1; amount <= target; amount++)
        {
            foreach(int coin in coins)
            {
                int remainder = amount - coin;

                if(remainder < 0 || best[remainder] == null) continue;

                int[] candidate = best[remainder]
                                    .Append(coin)
                                    .OrderBy(x => x)
                                    .ToArray();

                if(best[amount] == null || candidate.Length < best[amount].Length)
                {
                    best[amount] = candidate;
                }
            }
        }

        if(best[target] == null) throw new ArgumentException("Can't reach target with given coins");

        return best[target];  
    }
}