// public class Solution {
//     public int[] TwoSum(int[] numbers, int target) {
        
//         //int[] Ans = new int[2];
//         int NumbersLength = numbers.Length;

//         for(int i = 0 ; i < NumbersLength -1; i++)
//         {
//             for(int j = i+1; j < NumbersLength; j++)
//             {
//                 if(numbers[i] + numbers[j] == target)
//                 {
//                     // Ans[0] = i+1;
//                     // Ans[1] = j+1;

//                     return new int[] {i+1, j+1};
//                 }
//             }
//         }

//         return new int[] {0, 0};

//         //return Ans;
        
//     }
// }

public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        
    int LeftPointer = 0;
    int RightPointer = numbers.Length -1;

    while(LeftPointer < RightPointer)
    {
        if(numbers[LeftPointer] + numbers[RightPointer] > target)
        {
            RightPointer--;
        }
        else if(numbers[LeftPointer] + numbers[RightPointer] < target)
        {
            LeftPointer++;
        }
        else
        {
            return new int[] {LeftPointer+1, RightPointer+1};
        }
    }  

     return new int[] {0,0}; 
    } 
}