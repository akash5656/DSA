public class Solution {
    public IList<IList<string>> SolveNQueens(int n) {

        List<IList<char>> board = new();

        for(int i = 0;i < n;i++)
        {
            List<char> init = new();
            for(int j =  0; j < n; j++)
            {
                init.Add('.');
            }
            board.Add(init);
        }

        List<IList<string>> result = new();

        BackTrack(board,0,new HashSet<int>(),new HashSet<int>(),new HashSet<int>());

        void BackTrack(List<IList<char>>  board,int row, HashSet<int> colSet, HashSet<int> diagSet, HashSet<int> antiDiagSet)
        {
            if(row==n)
            {
                List<string> current = new();
                foreach(var item in board)
                {
                    current.Add(string.Join(string.Empty,item));
                }
                result.Add(current);
            }

            for(int col = 0; col < n; col++)
            {
                if(colSet.Contains(col) || diagSet.Contains(row-col) || antiDiagSet.Contains(row+col))
                    continue;

                board[row][col] = 'Q';
                colSet.Add(col);
                diagSet.Add(row-col);
                antiDiagSet.Add(row+col);

                BackTrack(board,row+1,colSet,diagSet,antiDiagSet);

                board[row][col] = '.';
                colSet.Remove(col);
                diagSet.Remove(row-col);
                antiDiagSet.Remove(row+col);
            }
        }


        return result;
        
    }
}