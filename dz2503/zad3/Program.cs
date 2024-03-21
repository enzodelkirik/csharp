/* Задача 3: Напишите программу, которая перевернёт одномерный массив 
(первый элемент станет последним, второй – предпоследним и т.д.) */

/* using System;

class Program
{
    static void Main()
    {
        int[] arr = new int[10];
        FillArray(arr);
        PrintArray(arr);
        ReverseArray(arr);
        PrintArray(arr);
    }

    static void FillArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = new Random().Next(1, 10);
        }
    }

    static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            System.Console.Write($"{arr[i]} ");
        }
    }

    static void ReverseArray(int[] arr)
    {
        for (int i = 0; i < arr.Length / 2; i++)
        {
            int temp = arr[i];
            arr[i] = arr[arr.Length - 1 - i];
            arr[arr.Length - 1 - i] = temp;
        }
    }
} */

/* using System;

class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 }; // Пример массива

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        ReverseArray(array);

        Console.WriteLine("Перевернутый массив:");
        PrintArray(array);
    }

    // Метод для переворачивания массива
    static void ReverseArray(int[] arr)
    {
        int start = 0;
        int end = arr.Length - 1;

        while (start < end)
        {
            // Обмен значениями
            int temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;

            start++;
            end--;
        }
    }

    // Метод для вывода массива на консоль
    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
 */

 using System;

class Program
{
    static void Main()
    {
        // Generate a random array
        int[] array = GenerateRandomArray(9);

        Console.WriteLine("Random array:");
        PrintArray(array);

        ReverseArray(array);

        Console.WriteLine("Reversed array:");
        PrintArray(array);
    }

    // Method to generate a random array
    static int[] GenerateRandomArray(int length)
    {
        Random random = new Random();
        int[] arr = new int[length];

        for (int i = 0; i < length; i++)
        {
            arr[i] = random.Next(1, 100); // Random numbers between 1 and 99
        }

        return arr;
    }

    // Method to reverse an array
    static void ReverseArray(int[] arr)
    {
        int start = 0;
        int end = arr.Length - 1;

        while (start < end)
        {
            // Swap values
            int temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;

            start++;
            end--;
        }
    }

    // Method to print an array
    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
