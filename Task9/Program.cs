﻿// // Task9: 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8


Console.Clear();
int n = new Random().Next(10, 100);
Console.WriteLine($"Случайное число: {n}");
int n1 = n / 10; // Количество десятков
int n2 = n % 10; // Количество единиц (последняя цифра числа)
if (n1 > n2)
    Console.Write(n1);
else
    Console.Write(n2);