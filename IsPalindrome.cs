 public static bool IsPalindrome(int number)
    {
        int originalNumber = number;
        int reversed = 0;

        while (number != 0)
        {
            int remainder = number % 10;
            reversed = reversed * 10 + remainder;
            number = number / 10;
        }

        return originalNumber == reversed;
    }