public class Solution {
    public int CountPrimeSetBits(int left, int right) {

        int result = 0;

        List<int> prime = new(){2,3,5,7,11,13,17,19};

        for(int i = left; i<=right;i++)
        {
            int setBits = BitOperations.PopCount((uint)i);

            if(prime.Contains(setBits))
                result++;
        }
        
        return result;
    }
}