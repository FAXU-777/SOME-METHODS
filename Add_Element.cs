 public static int[] AddElement(int[] arr, int element)
    {
        int length = arr.Length;
        int[] newArr = new int [length + 1];
        
        
        for (int i = 0; i < length; i++)
        {
            newArr[i] = arr[i];
        }
        
        newArr[length] = element;
        
        return newArr;
    }