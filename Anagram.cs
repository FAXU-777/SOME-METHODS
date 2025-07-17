 public static bool Anagram(string word1, string word2)
    {
        if (word1.Length != word2.Length)
        {
            return false;
        }
        

        char[] arr1 = word1.ToLower().ToCharArray();
        char[] arr2 = word2.ToLower().ToCharArray();
        Array.Sort(arr1);
        Array.Sort(arr2);

        for (int i = 0; i < arr1.Length; i++)
        {
            if (arr1[i] != arr2[i])
            {
                return false;
            }
        }
        return true;
        
    }