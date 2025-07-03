public class Solution {
    public char KthCharacter(int k) {

        int shift = BitOperations.PopCount((uint)(k-1));
        return (char)('a' + shift);

        
    }
}