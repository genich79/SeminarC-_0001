// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"


string rec(int m, int n)
{
    if (n == m)
        return $"{m} ";
    return rec(m, n - 1) + $"{n} ";
}


Console.Clear();
Console.Write("Введите число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(m, n));







// Не верное решение


// string rec(int n, int m)
// {
//     if (n < 0 && m < 0)
//         return "0 ";
//     return rec(m - n) + $"{n} + {m} ";
// }



// Console.Clear();
// Console.Write("Введите число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(rec(n, m));