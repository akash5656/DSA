public class Solution {
    public int MaxFreeTime(int eventTime, int k, int[] startTime, int[] endTime) {
        List<int> free = new List<int>();

        free.Add(startTime[0]);

        for(int m=1;m<startTime.Length;m++)
        {
            free.Add(startTime[m]-endTime[m-1]);
        }

        free.Add(eventTime - endTime[endTime.Length-1]);

        int i = 0;
        int j = 0;
        int max = 0;
        int currSum = 0;

        while(j < free.Count)
        {
            currSum += free[j];

            while(i < free.Count && j-i+1 > k+1)
            {
                currSum -= free[i];
                i++;
            }

            max = Math.Max(currSum,max);
            j++;
        }

        return max;
    }
}