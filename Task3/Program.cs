﻿// Task3: Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// Например: 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4", 2 -> " -2, -1, 0, 1, 2"
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()); // ввод чисел
int i = n * (-1);
while (i <= n)
{
    Console.Write($"{i} ");
    i = i + 1; // i++;
}

/*
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()); // ввод чисел
for (int i = (-1) * n; i <= n; i++)
    Console.Write($"{i} ");
*/    