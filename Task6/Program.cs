﻿// Task6: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// Например: 2, 3, 7 -> 7, 44 5 78 -> 78, 22 3 9 -> 22
Console.Clear();
Console.WriteLine("Введите три числа: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int max = a;

    if (b > max)
        max = b;

    if (c > max)
        max = c;
    
    Console.WriteLine("Наибольшее из введённых чисел " + max);