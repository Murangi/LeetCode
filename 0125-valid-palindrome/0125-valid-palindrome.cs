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
