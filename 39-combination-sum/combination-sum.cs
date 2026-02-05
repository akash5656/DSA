public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {

        List<IList<int>> result = new();
        List<int> current = new();
        Array.Sort(candidates);

        BackTrack(0,target);

        void BackTrack(int start, int newTarget)
        {
            if(newTarget == 0)
            {
                result.Add(new List<int>(current));
                return;
            }
            for(int i = start; i < candidates.Length; i++)
            {
                if(newTarget >= candidates[i])
                {
                    current.Add(candidates[i]);
                    BackTrack(i,newTarget - candidates[i]);
                    current.RemoveAt(current.Count-1);
                }
                else
                    break;
                
            }
        }
        
        return result;
    }
}