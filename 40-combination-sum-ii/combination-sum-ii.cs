public class Solution {
    public IList<IList<int>> CombinationSum2(int[] candidates, int target) {
        List<IList<int>> result = new();
        List<int> current = new();

        Array.Sort(candidates);

        BackTrack(0,target);

        void BackTrack(int start,int newTarget)
        {
            if(newTarget == 0)
            {
                result.Add(new List<int>(current));
                return;
            }

            for(int i = start; i< candidates.Length; i++)
            {
                if(candidates[i] > newTarget)
                break;

                if(i > start && candidates[i-1]==candidates[i])
                    continue;

                current.Add(candidates[i]);
                BackTrack(i+1,newTarget-candidates[i]);
                current.RemoveAt(current.Count-1);
            }
        }

        return result;
    }
}