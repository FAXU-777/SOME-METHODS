 public static string MiddleCharacter(string word)
    {
        int mid = word.Length / 2;

        if (word.Length == 1)
        {
            return word;
        }

        if (word.Length % 2 == 0)
        {
            return word[mid - 1].ToString() + word[mid].ToString();
        }
        else
        {
            return word[mid].ToString();
        }
        
    }
