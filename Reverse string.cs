 public static String ReverseString(String input)
    {
        String reversed = " ";
        foreach (char a in input)
        {
            reversed = a + reversed;
        }

        return reversed;

    }
