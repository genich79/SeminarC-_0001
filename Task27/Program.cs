// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120


Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()); 
  int result = 1;
  for (int i = 1; i <= n; i++)  
    result = result * i;
    Console.Write($"{result} ");   


// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine()), result = 1;
// for (int i = 1; i <= n; i++)
//     result *= i; // result = result * i
// Console.WriteLine($"Результат: {result}");
 



   


    