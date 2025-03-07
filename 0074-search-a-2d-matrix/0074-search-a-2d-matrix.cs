public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        
        
        int Row = matrix.Length;  // Correct way to get number of rows
        
        for(int i = 0; i < Row; i++) {
            int Column = matrix[i].Length; // Correct way to get number of columns in row `i`
            
            for(int j = 0; j < Column; j++) {
                if(matrix[i][j] == target) {
                    return true;
                }
            }
        }

        return false;

    }
}