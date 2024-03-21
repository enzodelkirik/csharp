/* Заполните массив на N (вводится с консоли, не более 8)
случайных целых чисел от 0 до 9.
Сформируйте целое число, которое будет состоять из цифр из
массива. Старший разряд числа находится на 0-м индексе,
младший – на последнем.
Пример
[1 3 2 4 2 3] => 132423
[2 3 1] => 231 */

int[] FillArray(int size)
{
    System.Console.WriteLine("Заполните массив");
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

void PrintArray(int[] arrayToPrint)
{
    Console.Write("[");
    for (var i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i != arrayToPrint.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
    Console.WriteLine();
}

int [] user_arr = FillArray(8);
PrintArray(user_arr);

int GetNumber (int [] arr)
{
    int number = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        number = number * 10 + arr[i];
    }
    return number;
}
System.Console.WriteLine(GetNumber(user_arr));