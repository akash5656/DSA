public class Solution {
    public IList<string> LetterCombinations(string digits) {

        List<string> result = new();

        Dictionary<char,string> map = new Dictionary<char,string>{
            {'2',"abc"},
            {'3',"def"},
            {'4',"ghi"},
            {'5',"jkl"},
            {'6',"mno"},
            {'7',"pqrs"},
            {'8',"tuv"},
            {'9',"wxyz"},
        };

        List<char> current = new();

        var input = digits.ToCharArray();

        BackTrack(0);


        void BackTrack(int start)
        {

            if(current.Count == input.Length)
            {
                result.Add(new string(current.ToArray()));
            }
            for(int i = start; i < input.Length; i++)
            {
                var refArr = map[input[i]].ToCharArray();
                for(int j=0; j < refArr.Length; j++)
                {
                    current.Add(refArr[j]);
                    BackTrack(i+1);
                    current.RemoveAt(current.Count-1);
                }
            }
        }

        return result;
        
    }
}