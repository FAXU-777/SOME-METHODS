 public static int SecondLargest(int[] numbers)
    {
        int max = 0;
        int secondMax = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > secondMax && numbers[i] < max)
            {
                secondMax = numbers[i];
            }
        }
        
        
        return secondMax;
    }
