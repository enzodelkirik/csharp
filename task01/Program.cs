/* программа, которая на вход принимает 
2 числа и проверяет, является ли первое 
число квадратом второго 

a = 25, b = 5 - yes
a = 2, b = 10 - no
a = 9, b = -3 - yes
a = -3, b = 9 - no
*/

Console.WriteLine("введите 2 числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2 * number2)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}