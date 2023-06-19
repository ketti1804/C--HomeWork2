/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет*/

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
if (num < 100)
{
    Console.WriteLine($"Третьей цифры нет");
    return;
}
int a = num % 10;
Console.WriteLine(a);