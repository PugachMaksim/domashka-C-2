/*  
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6  
*/

int a;
Console.Write("Введите число: ");
int.TryParse(Console.ReadLine(), out a);
if (a>99)
{
    while (a > 1000)
        {
            a = a/10;
        }
    Console.WriteLine(a%10);
}
else
{
    Console.WriteLine($"{a}  -> третьей цифры нет");
}