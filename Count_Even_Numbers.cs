 public static int CountEvenNumbers(int[] numbers)
    {
        int counter = 0; // created to count even numbers in the array
        
        for (int i = 0; i < numbers.Length; i++) //used to repeat and see the elements
        {
            if (numbers[i] % 2 == 0) // check if the number is even or odd
            {
                counter++;  //if it is even then counter will be raised by one
            }
        }

        return counter; //finally return counter
    }
