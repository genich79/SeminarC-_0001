// Task10: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98
Console.Clear();
int n = new Random().Next(100, 1000); // [100, 999]
Console.WriteLine($"Случайное число: {n}");
int n1 = n / 100; // кол-во сотен
int n3 = n % 10; // кол-во единиц(последняя цифра числа)
Console.Write(n1 * 10 + n3);