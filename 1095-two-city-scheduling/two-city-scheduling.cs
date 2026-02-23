public class Solution {
    public int TwoCitySchedCost(int[][] costs) {

        Array.Sort(costs, (x,y) => (y[1]-y[0]).CompareTo(x[1]-x[0]));

        int result = 0;

        for(int i = 0; i < costs.Length; i++)
        {
            if(i < costs.Length/2)
            {
                result+= costs[i][0];
            }
            else
                result+=costs[i][1];
        }
        
        return result;
    }
}