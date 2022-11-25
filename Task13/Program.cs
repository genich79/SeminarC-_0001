// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет
Console.Clear();
Console.Write("Введите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите 2-ое число: ");
int m = Convert.ToInt32(Console.ReadLine()); 
if (m * m == n || n * n == m)
    Console.Write("yes");
else
    Console.Write("no");
