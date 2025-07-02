public class Solution {
    public int PossibleStringCount(string word, int k) {
        if(word.Length == 0)
            return 0;

        int MOD = 1_000_000_007;
        List<int> groups = new List<int>();
        int count = 1;

        for (int i = 1; i < word.Length; i++)
        {
            if (word[i] == word[i - 1])
                count++;
            else
            {
                groups.Add(count);
                count = 1;
            }
        }

        groups.Add(count);

        // Step 2: Total ways = product of group sizes
        long totalWays = 1;
        foreach (int g in groups)
            totalWays = (totalWays * (long)g) % MOD;

        if(k<=groups.Count)
            return (int)totalWays;

        // Step 3: DP to count number of combinations with sum < k
        int[] dp = new int[k];
        dp[0] = 1;

        foreach (int g in groups)
        {
            int[] newDp = new int[k];
            long sum = 0;
            int[] prefix = new int[k + 1];

            // Build prefix sum
            for (int i = 0; i < k; i++)
            {
                if(i > 0)
                    sum = (sum + dp[i-1]) % MOD;
                if(i > g)
                    sum = (sum - dp[i-g-1] + MOD) % MOD;
                newDp[i] = (int)sum;
            }

            dp = newDp;
        }

        // Step 4: Subtract invalid combinations (sum < k)
        long bad = 0;
        for (int i = groups.Count; i < k; i++)
            bad = (bad + dp[i]) % MOD;

        long result = (totalWays - bad + MOD) % MOD;
        return (int)result;
    }
}