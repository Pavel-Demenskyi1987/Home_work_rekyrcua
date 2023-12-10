using System;

class Program
{
    public static void Main()
    {
        int[] array =  new int[]{9 ,5 ,4 ,7 ,2};
        GetArray(array,  array.Length- 1);

        Console.ReadLine(); 
    }
    

    public static void GetArray(int[] arr, int index)
    {
        if (index < 0)
            return;

        Console.WriteLine(arr[index]);
        GetArray(arr, index - 1);
    }
}
