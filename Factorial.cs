   public static int Factorial(int number)
    {
        if (number == 0)
        {
            return 1;
        }

        int result = 1;
        
        while (number != 0)
        {
            result = result * number;
            number--;

        }
        return result;
    }