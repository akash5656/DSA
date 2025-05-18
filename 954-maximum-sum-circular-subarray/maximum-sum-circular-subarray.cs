public class Solution {
    public int MaxSubarraySumCircular(int[] nums) {
        int max_normal =  CalculateMaxSum(nums);

        if(max_normal<0) {
            return max_normal;
        }

        int circlularSum = 0;

        for(int i = 0;i<nums.Length;i++) {
            circlularSum+=nums[i];
            nums[i]=-nums[i];
        }
        // converting all the numbers to opposite sign to calculate max and then add it to total
        // means finding out the minimum sum and subtract it from the whole sum to get max of circular sum
        // to do this either create a minimum sum algo using Kadane's algo or inverse the sign and use
        // Kadane's algo to find max and then add it to previous total sum
        int maxCircular = circlularSum + CalculateMaxSum(nums);

        return Math.Max(maxCircular,max_normal);
    }

    // kadane's algo to calculate max sum of an subarray
    public int CalculateMaxSum(int[] nums) {
        int max = nums[0];
        int res = nums[0];

        for(int i = 1;i<nums.Length;i++) {
            max=Math.Max(nums[i],max+nums[i]);
            res = Math.Max(res,max);
        }

        return res;
    }
}