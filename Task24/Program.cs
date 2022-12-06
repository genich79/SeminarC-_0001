// Напишите программу, которая принимает на вход пятизначное любое и проверяет, является ли оно палиндромом.

Console.Clear();
Console.Write("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = n;
int newNumber = 0, i = Convert.ToString(n).Length - 1;
while (i >= 0)
{
    newNumber = newNumber + (n % 10 * Convert.ToInt32(Math.Pow(10, i)));
    n = n / 10;
    i--;
}
Console.WriteLine(newNumber == result);

// Console.WriteLine("Нажмите любую клавишу, а затем Enter");
// int key1 = Console.Read();
// Console.WriteLine($"Код нажатой клавиши: {key1}");
// Console.WriteLine("Символьное представление: " + Convert.ToChar(key1));

// Console.WriteLine("Введите ваше имя, а затем нажмите Enter");
// string name = Console.ReadLine();
// Console.WriteLine($"Привет, {name}!");