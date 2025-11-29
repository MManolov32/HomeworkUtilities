using System;

class Program
{
    static void Main()
    {
        int[] nums = { 5, 1, 7, 3, 9, 2 };

        SortDescending(nums);

        Console.WriteLine("Sorted descending:");
        foreach (int n in nums)
            Console.WriteLine(n);
    }

    static int FindBiggest(int[] arr)
    {
        int biggest = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > biggest)
            {
                biggest = arr[i];
            }
        }
        return biggest;
    }

    static void SortDescending(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] > arr[i])
                {
                    int tmp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = tmp;
                }
            }
        }
    }
}

