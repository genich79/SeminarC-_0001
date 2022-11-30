// Task15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();
Console.Write("Введите день недели: ");
int n = Convert.ToInt32(Console.ReadLine()); 
while (n <= 5 && n >= 1)
{
    Console.Write("Вы ошиблись!\nДень является будним\nВведите новый день недели: ");
    n = Convert.ToInt32(Console.ReadLine());    
}
if (n >= 6 && n <= 7)
    Console.WriteLine($"{n} -> День является выходным!");
   

// {
//    Console.Write($"{n} -> нет, день является будним! \nВведите новый день недели: ");
//    n = Convert.ToInt32(Console.ReadLine()); 
// }
// if (n == 6)
//       Console.WriteLine($"{n} -> да, день является выходным!");
// else if (n == 7)
//       Console.WriteLine($"{n} -> да, день является выходным!");

