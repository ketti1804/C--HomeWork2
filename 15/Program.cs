/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

Console.WriteLine("Введите номер дня недели");
int weekDay = int.Parse(Console.ReadLine());
bool IsWeekend(int weekDay)
{
    if (weekDay > 5)
    {
        return true;
    }
    return false;
}
bool validateWeekday(int num)
{
    if (num > 0 && num <= 7)
    {
        return true;
    }
    Console.WriteLine("Это не номер дня недели");
    return false;
}
if (validateWeekday(weekDay))
{
    if (IsWeekend(weekDay)) Console.WriteLine("Наконец-то выходной!");
    else Console.WriteLine("Снова будни!");
}