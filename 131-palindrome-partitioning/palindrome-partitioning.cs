public class Solution {
    public IList<IList<string>> Partition(string s) {
        
        List<string> current = new();

        List<IList<string>> result = new();

        BackTrack(s);


        void BackTrack(string remaining)
        {

            if(string.IsNullOrEmpty(remaining))
            {
                result.Add(new List<string>(current));
                return;
            }

            for(int i=1; i <= remaining.Length; i++)
            {
                string choice = remaining.Substring(0,i);

                if(!isPalindrome(choice))
                    continue;

                current.Add(choice);
                BackTrack(remaining.Substring(i));
                current.RemoveAt(current.Count-1);
            }
        }


        bool isPalindrome(string s)
        {
            if(string.IsNullOrEmpty(s))
                return false;

            if(s.Length==1)
                return true;

            int i = 0;
            int j = s.Length-1;

            while(i < j)
            {
                if(s[i++]!=s[j--])
                    return false;
            }

            return true;
        }

        return result;

    }
}