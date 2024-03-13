/*
Программа, которая выдает название дня недели по номеру
3 - среда
5 - пятница
*/

int number = Convert.ToInt32(Console.ReadLine());
if (number == 1)
{
    Console.Write("понедельник");
}
else if (number == 2)
{
    Console.Write("вторник");
}
else if (number == 3)
{
    Console.Write("среда");
}
else if (number == 4)
{
    Console.Write("четверг");
}
else if (number == 5)
{
    Console.Write("пятница");
}
else if (number == 6)
{
    Console.Write("суббота");
}
else if (number == 7)
{
    Console.Write("воскресенье");
}
else
{
    Console.Write("такого дня недели нет");
}