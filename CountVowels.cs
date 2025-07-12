    public static int CountVowels(string input)
    {
        int counter = 0;
        char [] vowels = { 'a', 'A', 'e', 'E', 'i', 'I', 'O', 'o', 'u', 'U' };

        for (int i = 0; i < input.Length; i++)
        {
            for (int j = 0; j < vowels.Length; j++)
            {
                if (input[i] == vowels[j])
                {
                    counter++;
                }
                
            }

        }
        return counter;

    }