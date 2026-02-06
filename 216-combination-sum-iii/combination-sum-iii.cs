public class Solution {
    public IList<IList<int>> CombinationSum3(int k, int n) {
        List<IList<int>> result = new();
        List<int> current = new();

        BackTrack(k,1,n);

        void BackTrack(int k, int start, int newTarget)
        {

            if(k==0 && newTarget == 0)
            {
                result.Add(new List<int>(current));
                return;
            }

            for(int i = start; i <= 9; i++)
            {
                if(i > newTarget)
                    break;

                current.Add(i);
                BackTrack(k-1,i+1,newTarget-i);
                current.RemoveAt(current.Count-1);
            }
        }

        return result;
    }
}