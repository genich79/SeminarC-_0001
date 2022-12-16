// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

// void InputArray(int[] array)
// {    
//     for (int i = 1; i < array.Length; i++)
//         {
//             Console.WriteLine($"Число {i}");
//             array[i] = Convert.ToInt32(Console.ReadLine());
//         }
// }

// int ReleaseArray(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0 )
//             count++;
//     }
//     return count;
// }
// Console.Clear();
// Console.WriteLine("Введите числа с клавиатуры\t");
// int[] array = new int[11];
// InputArray(array);
// Console.WriteLine($"Количество чисел больше нуля равно: {ReleaseArray(array)}");



// 41 task
Console.Clear();

Console.Write("Введите кол-во чисел: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i = 0; i < n; i++)
{
    if (Convert.ToInt32(Console.ReadLine()) > 0)
        count++;
}
Console.WriteLine(count);



// 41 task
// Console.Clear();

// string[] n = Console.ReadLine().Split(" ");
// int count = 0;
// foreach (string i in n)
// {
//     if (int.Parse(i) > 0)
//         count++;
// }
// Console.WriteLine(count);



// 41 task
// Console.Clear();

// int[] array = {1, 2, 3, 4, 5};
// int count = 0;
// foreach (int i in array)
// {
//     if (i > 0)
//         count++;
// }
// Console.WriteLine(count);


