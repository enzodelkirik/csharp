/*
Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.
*/


string inputString = "123454321";
bool isPalindrome = true;

for (int i = 0; i < inputString.Length / 2; i++)
{
    if (inputString[i] != inputString[inputString.Length - 1 - i])
    {
        isPalindrome = false;
        break;
    }
}

Console.WriteLine($"Строка {(isPalindrome ? "является" : "не является")} палиндромом");
