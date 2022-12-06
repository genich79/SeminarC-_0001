// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число");
string? n = Console.ReadLine();
int sum = 0;
for (int i = 0; i < n?.Length; i++)
{
    sum = sum + (int) char.GetNumericValue((n[i])); //sum = sum + n[i] - 48
    // sum = sum + int.Parse(n[i].ToString()); переводим символ в строку, строку в число
}    
    Console.WriteLine($"Сумма цифр в числе равна:  {sum}");
    


// Console.Clear();
// Console.Write("Введите число: ");
// string? n = Console.ReadLine();
// int result = 0;
// for (int i = 0; i < n.Length; i++)
//     result = result + int.Parse(n[i].ToString());

// Console.WriteLine(result);


// Console.WriteLine("Введите число");
// int n = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// while (n > 0)
//     {
//         sum = sum + n % 10; //sum += n % 10 
//         n /= 10;
//     }
//     Console.WriteLine(sum);
