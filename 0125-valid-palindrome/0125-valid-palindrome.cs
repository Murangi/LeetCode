// public class Solution {
//     public bool IsPalindrome(string s) {
        
//         string AcceptedCharacters = "abcdefghijklmnopqrstuvwxyz0123456789"; 
//         string NewWord = "";

//         if(s == "" || s == " ")
//         {
//             return true;
//         }
        
//         s = s.ToLower();
        
//         //Getting only the alphanumeric characters
//         foreach(char Letter in s)
//         {
//             if(s.Contains(AcceptedCharacters))
//             {
//                 NewWord += Letter;
//             }
//         }

//         char[] NewWordArray = new char[NewWord.Length];
//         NewWordArray = NewWord.ToCharArray();
        
//         //going to check if the word is a palindrome
//         int Beginning = 0;
//         int End = NewWordArray.Count() -1;

//         if(NewWord.Length % 2 != 0)
//         {
          
//           while(End != Beginning)
//           {
//             if(NewWordArray[Beginning] != NewWordArray[End])
//             {
//                 return false;
//             }

//             Beginning++;
//             End--;
//           }

//         }
//         else
//         {
//            while((End - Beginning) == 1)
//            {
//              if(NewWordArray[Beginning] != NewWordArray[End])
//              {
//                 return false;
//              }

//              Beginning++;
//              End--;
//            }
//         }

//         return true;
        

//     }
// }

public class Solution
{
    public bool IsPalindrome(string s)
    {
        string AcceptedCharacters = "abcdefghijklmnopqrstuvwxyz0123456789";
        string NewWord = "";

        if (string.IsNullOrEmpty(s.Trim()))
        {
            return true;
        }

        s = s.ToLower();

        // Filter out only the alphanumeric characters
        foreach (char Letter in s)
        {
            if (AcceptedCharacters.Contains(Letter))
            {
                NewWord += Letter;
            }
        }

        // Check if the filtered word is a palindrome
        int Beginning = 0;
        int End = NewWord.Length - 1;

        while (Beginning < End)
        {
            if (NewWord[Beginning] != NewWord[End])
            {
                return false;
            }
            Beginning++;
            End--;
        }

        return true;
    }
}
