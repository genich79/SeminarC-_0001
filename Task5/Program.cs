// Task5: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// Например: a = 5; b = 7 ->  max = 7, a = 2 b = 10 -> max = 10, a = -9 b = -3 -> max = -3

Console.Clear();
Console.WriteLine("Введите два числа: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
    Console.WriteLine("{0} наибольшее число", a);  
else
    Console.WriteLine("{0} наибольшее число", b);

/*
Обясните какая разница в этих трех записях, или это одно и тоже только поразному записано?
    Console.WriteLine("{0} наибольшее число", a);
    Console.WriteLine( + a + " наибольшее число");
    Console.WriteLine($"{a} наибольшее число");

Console.Clear();
Console.WriteLine("Введите два числа: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
    Console.WriteLine( + a + " наибольшее число");
else
    Console.WriteLine( + b + " наибольшее число");


Console.Clear();
Console.WriteLine("Введите два числа: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
    Console.WriteLine($"{a} наибольшее число");
else
    Console.WriteLine($"{b} наибольшее число");
*/    