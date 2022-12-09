// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

void InputArray(int[] array)
{    
    for (int i = 1; i < array.Length; i++)
        {
            Console.WriteLine($"Число {i}");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
}

int ReleaseArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0 )
            count++;
    }
    return count;
}
Console.Clear();
Console.WriteLine("Введите числа с клавиатуры\t");
int[] array = new int[11];
InputArray(array);
Console.WriteLine($"Количество чисел больше нуля равно: {ReleaseArray(array)}");