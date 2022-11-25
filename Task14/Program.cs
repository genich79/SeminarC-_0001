// Task13: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.Write("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine()); 
int n1 = n / 10; 
int n2 = n1 / 10;
Console.Write (n1 - n2 * 10 );