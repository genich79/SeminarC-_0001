﻿// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число");
string n = Console.ReadLine();
int m = n.Length;

if (m == 5)
{
    if (n[0] == n[4] && n[1] == n[3])
    Console.WriteLine("Палиндром");
    else
    Console.WriteLine("Не палиндром");
}