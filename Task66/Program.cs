﻿// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

string rec(int n)
{
    if (n == 1)
        return "1 ";
    return rec(n - 1) + $"{n} ";
}


Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(n));





// int rec(int n)
// {
//     if (n == 1)
//         return 1;
//     return rec(n - 1) + n;
// }


// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(rec(n));




// void rec(int n)
// {
//     if (n == 1)
//         Console.Write(n + " ");
//     if (n > 1)
//     {    
//         rec(n - 1);
//         Console.Write(n + " ");
//     }
// }


// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// rec(n);
