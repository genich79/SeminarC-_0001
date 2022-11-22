// Task1: Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
Console.Clear();
Console.Write("Введите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine()); // ввод чисел
Console.Write("Введите 2-ое число: ");
int m = Convert.ToInt32(Console.ReadLine()); // ввод чисел
if (m * m == n)
    Console.Write("yes");
else
    Console.Write("no");