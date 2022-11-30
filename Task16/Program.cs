// Напишите программу, которая выводит третью цифру(c начала) заданного числа или сообщает, что третьей цифры нет.
// НЕ ИСПОЛЬЗОВАТЬ НУМЕРАЦИЮ СТРОК
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.Write("Введите любое число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 100)
{
    Console.Write("Третьей цифры нет\nВведите новое число: ");
    n = Convert.ToInt32(Console.ReadLine());    
}
else
{
    while (n > 1000)
        n = n / 10;
        Console.WriteLine(n % 10);
}   