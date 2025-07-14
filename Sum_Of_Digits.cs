 public static int SumOfDigits(int num)
    {
        int rem ;
        int sum=0;

        while (num != 0)
        {
            rem = num % 10;
            num = num / 10;
            sum = sum + rem;
        }

        return sum;
    }