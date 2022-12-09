// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

// Console.Write("Введите строну A: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите строну B: ");
// int B = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите строну C: ");
// int C = Convert.ToInt32(Console.ReadLine());

// if ((A + B > C) && (B + C > A) && (C + A > B);
// {
//     double triangle = (A + B + C) / 2;
// Console.WriteLine("Это треугольник");
//             Console.WriteLine("Площадь треугольника: " + Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
//         }
//         else
//         {
//             Console.WriteLine("Это не треугольник");
//  }



Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int c = Convert.ToInt32(Console.ReadLine());
if (a < b + c && b < a + c && c < a + b)
    Console.WriteLine("Может");
else
    Console.WriteLine("Не может");





// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// string result = String.Empty;
// while (n > 0)
// {
//     result = Convert.ToString(n % 2) + result;
//     n /= 2;
// }
// Console.WriteLine(result);

